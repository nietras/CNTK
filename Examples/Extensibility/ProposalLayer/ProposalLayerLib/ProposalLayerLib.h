//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

#pragma once
#include "CNTKLibrary.h"
#include "RpnUtils.h"
#include "NmsUtils.h"
#include "Nms.h"
#include <queue>

using namespace CNTK;

using ScoredRectangle2D = std::pair<float, Rectangle2D>;

// returns true if the left box score is greater than the right box score.
static auto cmp = [](const ScoredRectangle2D& left, const ScoredRectangle2D& right) {
    if (left.first == right.first)
        return left.second.Area() > right.second.Area();

    return (left.first > right.first);
};

using SortedRectangle2DPriorityQueue = std::priority_queue<ScoredRectangle2D, std::vector<ScoredRectangle2D>, decltype(cmp)>;

class ProposalLayer final : public Function
{
    uint32_t m_featStride{16};
    std::vector<Rectangle2D> m_anchors;
    size_t m_preNMSTopN, m_postNMSTopN;
    float m_NMSThresh, m_minSize;
    bool m_trainMode;

    enum Inputs : uint32_t
    {
        SCORES,
        BBOX_DELTAS,
        IM_INFO
    };

public:
    ProposalLayer(const std::vector<Variable>& inputs, const Dictionary& attributes, const std::wstring& name = L"ProposalLayer")
        : Function(inputs, attributes, name),
          m_preNMSTopN{0},
          m_postNMSTopN{0},
          m_NMSThresh{0},
          m_minSize{0},
          m_trainMode(true)
    {
        if (attributes.Contains(L"feat_stride"))
            m_featStride = static_cast<uint32_t>(attributes[L"feat_stride"].Value<int>());

        std::vector<uint32_t> scales{{8, 16, 32}};
        if (attributes.Contains(L"scales"))
        {
            scales.clear();
            const auto& valueVector = attributes[L"scales"].Value<std::vector<DictionaryValue>>();
            for (const auto& value : valueVector)
                scales.push_back(static_cast<uint32_t>(value.Value<int>()));
        }

        ChangeConfiguration(m_trainMode);

        m_anchors = GenerateAnchors(scales);

    }

    // 2021.09.06 - sigfrid696
	// Mixed CPU/GPU evaluation is supported at the moment, but managed inside Forward routine
	// Using this method the caller can handle cases of not supported devices, to avoid the exception 
    bool SupportedDevice(const DeviceDescriptor& device) const
    {
        //return device.Type() == DeviceDescriptor::CPUDevice().Type();
        return true;
    }

private:
    void ChangeConfiguration(bool train)
    {
        const auto& attributes = Attributes();
        if (train)
        {
            m_preNMSTopN = attributes[L"train_pre_nms_topN"].Value<int>();
            m_postNMSTopN = attributes[L"train_post_nms_topN"].Value<int>();
            m_NMSThresh = static_cast<float>(attributes[L"train_nms_thresh"].Value<double>());
            m_minSize = static_cast<float>(attributes[L"train_min_size"].Value<double>());
        }
        else
        {
            m_preNMSTopN = attributes[L"test_pre_nms_topN"].Value<int>();
            m_postNMSTopN = attributes[L"test_post_nms_topN"].Value<int>();
            m_NMSThresh = static_cast<float>(attributes[L"test_nms_thresh"].Value<double>());
            m_minSize = static_cast<float>(attributes[L"test_min_size"].Value<double>());
        }
    }

    std::vector<Rectangle2D> GetAllShiftedAnchors(size_t w, size_t h)
    {
        std::vector<Rectangle2D> anchors;
        anchors.reserve(w * h * m_anchors.size());

        for (const auto& anchor : m_anchors)
        {
            for (size_t j = 0; j < h; j++)
            {
                auto y = float(j * m_featStride);

                for (size_t i = 0; i < w; i++)
                {
                    auto x = float(i * m_featStride);
                    anchors.emplace_back(anchor.xmin + x, anchor.ymin + y, anchor.xmax + x, anchor.ymax + y);
                }
            }
        }

        return anchors;
    }

    // 2021.09.06 - sigfrid696
    // mixed CPU/GPU evaluation is managed in this routine
    BackPropStatePtr Forward(const std::vector<ValuePtr>& inputValues,
                             std::unordered_map<Variable, ValuePtr>& outputs,
                             const DeviceDescriptor& computeDevice,
                             const std::unordered_set<Variable>& outputsToRetainBackwardStateFor) override
    {
        bool trainMode = outputsToRetainBackwardStateFor.size() != 0;
        if (m_trainMode != trainMode)
        {
            m_trainMode = trainMode;
            ChangeConfiguration(m_trainMode);
        }

        /*if (computeDevice.Type() != DeviceKind::CPU)
        throw std::runtime_error("ProposalLayer: only CPU evaluation is supported at the moment.");*/

        auto scoresShape = inputValues[Inputs::SCORES]->Shape();

        if (scoresShape[scoresShape.Rank() - 1] != 1)
            throw std::runtime_error("ProposalLayer: only single item batches are supported");

        auto width = scoresShape[0];
        auto height = scoresShape[1];
        // the first set of N (= m_anchors.size()) channels are bg probs
        // the second set are the fg probs, which we want
        std::vector<size_t> offsets{0, 0, 0, 0};
        offsets[2] = m_anchors.size();

        auto extent = scoresShape.Dimensions();
        extent[2] -= m_anchors.size();

        auto fgSlice = inputValues[Inputs::SCORES]->Data()->SliceView(offsets, extent, true);

        DeviceDescriptor computeDevice_CPU = ::CNTK::DeviceDescriptor::CPUDevice();
        NDArrayViewPtr fgSlice_CPU;
        NDArrayViewPtr bboxDeltas_CPU;
        NDArrayViewPtr imInfo_CPU;
        const float* scores = nullptr;
        const float* bboxDeltas = nullptr;
        const float* imInfo = nullptr;

        if (computeDevice.Type() != DeviceKind::CPU)
        {
            fgSlice_CPU = fgSlice->DeepClone(computeDevice_CPU, true);
            bboxDeltas_CPU = inputValues[Inputs::BBOX_DELTAS]->Data()->DeepClone(computeDevice_CPU, true);
            imInfo_CPU = inputValues[Inputs::IM_INFO]->Data()->DeepClone(computeDevice_CPU, true);

            scores = fgSlice_CPU->DataBuffer<float>();
            bboxDeltas = bboxDeltas_CPU->DataBuffer<float>();
            imInfo = imInfo_CPU->DataBuffer<float>();
        }
        else
        {
            scores = fgSlice->DataBuffer<float>();
            bboxDeltas = inputValues[Inputs::BBOX_DELTAS]->Data()->DataBuffer<float>();
            imInfo = inputValues[Inputs::IM_INFO]->Data()->DataBuffer<float>();
        }

        // Enumerate all shifted anchors, which will produce (A * H * W) anchors
        auto anchors = std::move(GetAllShiftedAnchors(width, height));

        // Convert anchors into proposals via bbox transformations,
        // input bbox deltas are stored as (H, W, 4 * A, 1)
        auto proposals = std::move(TransformBboxInv(anchors, bboxDeltas, width * height));

        // 2. clip predicted boxes to image
        ClipBoxes(proposals, imInfo);

        m_preNMSTopN = (m_preNMSTopN > 0) ? std::min(proposals.size(), m_preNMSTopN) : proposals.size();

        // 3. remove predicted boxes with either height or width < threshold
        // (NOTE: convert min_size to input image scale. Original size = im_info[4:6], scaled size = im_info[2:4])

        // 4. Take top pre_nms_topN(e.g. 6000) proposals with highest scores.
        // Priority queue here is effectively a min heap, the top of the pq has the lowest score
        // among the top-N elements.

        SortedRectangle2DPriorityQueue pq(cmp);

        auto cntkImageScale = imInfo[2] / imInfo[4];
        auto minSize = m_minSize * cntkImageScale;

        for (size_t i = 0; i < proposals.size(); i++)
        {
            const auto& box = proposals[i];
            if (box.Width() < minSize || box.Height() < minSize)
                continue;

            pq.emplace(scores[i], box);
            if (pq.size() > m_preNMSTopN)
                pq.pop();
        }

        proposals.erase(proposals.begin() + pq.size(), proposals.end());

        for (size_t i = 0; !pq.empty(); i++)
        {
            proposals[pq.size() - 1] = std::move(pq.top().second);
            pq.pop();
        }

        // at this point, proposals contains m_preNMSTopN boxes sorted in the descending order of
        // their scores (from the highest to lowest).

        // 5. apply nms(e.g.threshold = 0.7), take after_nms_topN(e.g. 300) top proposals.
        m_postNMSTopN = (m_postNMSTopN > 0) ? std::min(proposals.size(), m_postNMSTopN) : proposals.size();
		
		// transform data to call nms gpu
        int n_boxes = proposals.size();
        int num_out; //how many boxes are keeped
        std::vector<int> keep_out(n_boxes); //keeped index of boxes_host
        std::vector<float> boxes_host(n_boxes * 4);
        for (size_t i = 0; i < n_boxes; i++)
        {
            boxes_host[i * 4] = proposals[i].xmin;
            boxes_host[i * 4 + 1] = proposals[i].ymin;
            boxes_host[i * 4 + 2] = proposals[i].xmax;
            boxes_host[i * 4 + 3] = proposals[i].ymax;
        }
        _nms(&keep_out[0], &num_out, &boxes_host[0], n_boxes, 4, m_NMSThresh);
        num_out = num_out < m_postNMSTopN ? num_out : m_postNMSTopN;
        std::vector<Rectangle2D> proposals_out;
        proposals_out.reserve(num_out);
        for (int i = 0; i < num_out; i++)
        {
            proposals_out.emplace_back(proposals[keep_out[i]]);
        }

        auto numFoundProposals = proposals_out.size();

        // 6. pad with zeros if too few rois were found
        if (numFoundProposals < m_postNMSTopN)
            proposals_out.resize(numFoundProposals, Rectangle2D(0, 0, 0, 0));

        // 7. create the output value and copy the data.
        NDArrayView outputData(DataType::Float, NDShape({4, numFoundProposals}),
                               proposals_out.data(), numFoundProposals * 4 * sizeof(float), computeDevice_CPU);

        auto outputValue = MakeSharedObject<Value>(
            MakeSharedObject<NDArrayView>(DataType::Float, NDShape({4, numFoundProposals}), computeDevice));

        NDArrayViewPtr outputDataPtr;
        if (computeDevice.Type() != DeviceKind::CPU)
        {
            outputDataPtr = outputData.DeepClone(computeDevice, true);
            outputValue->Data()->CopyFrom(*outputDataPtr);
        }
        else
        {
            outputValue->Data()->CopyFrom(outputData);
        }

        // Output rois blob
        outputs[this->Output()] = outputValue;

        return nullptr;
    }

    void Backward(const BackPropStatePtr& state,
                  const std::unordered_map<Variable, ValuePtr>& rootGradientValues,
                  std::unordered_map<Variable, ValuePtr>& backPropagatedGradientValuesForInputs) override
    {
        state;
        rootGradientValues;
        backPropagatedGradientValuesForInputs;
        return;
    }

    const std::wstring& OpName() const override
    {
        static const std::wstring opName = L"ProposalLayerOp";
        return opName;
    }

    size_t CurrentVersion() const override
    {
        NOT_IMPLEMENTED;
    }

    void InferOutputs(std::vector<Variable>& outputs) override
    {
        auto firstOperand = Function::Inputs()[0];
        auto proposalShape = NDShape({4, NDShape::FreeDimension});
        auto dtype = firstOperand.GetDataType();
        auto dynamicAxes = firstOperand.DynamicAxes();
        outputs.push_back(OutputVariable(proposalShape, dtype, dynamicAxes, false, L"rpn_rois_raw"));
    }

    FunctionPtr Clone(const std::vector<Variable>& clonedInputs) override
    {
        return AsComposite(MakeSharedObject<ProposalLayer>(clonedInputs, this->Attributes(), this->Name()));
    }
};
