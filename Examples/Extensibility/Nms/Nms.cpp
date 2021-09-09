
#include <vector>
#include "Rectangle2D.h"
#include "Nms.h"

#ifndef CPUONLY
#define ANAMEFORLIB "Cntk.Nms.Cuda-" ## CNTK_COMPONENT_VERSION ## ".lib"
#pragma comment(lib, ANAMEFORLIB) // built by NmsCUDA project
#undef ANAMEFORLIB
#endif

extern void gpu_nms(int* keep_out, int* num_out, const float* boxes_host, int boxes_num,
                    int boxes_dim, float nms_overlap_thresh, int device_id);

void cpu_nms(int* keep_out, int* num_out, const float* boxes_host, int boxes_num,
             int boxes_dim, float nms_overlap_thresh, int device_id = -1);

void _nms(int* keep_out, int* num_out, const float* boxes_host, int boxes_num,
	int boxes_dim, float nms_overlap_thresh, int device_id)
{
#ifndef CPUONLY
    gpu_nms(keep_out, num_out, boxes_host, boxes_num, boxes_dim, nms_overlap_thresh, device_id);
#else
   cpu_nms(keep_out, num_out, boxes_host, boxes_num, boxes_dim, nms_overlap_thresh, device_id);
#endif
}

// TODO: the current implementation is O(N^2), it should be possible to do this in O(N logN),
// see the sweeping line algorithm:  http://algs4.cs.princeton.edu/93intersection/
// Returns first topN elements from the input vector that do not overlap with any preceeding rectangle
// by more than a threshold ratio.
void cpu_nms(int* keep_out, int* num_out, const float* boxes_host, int boxes_num,
          int boxes_dim, float nms_overlap_thresh, int device_id)
{
    std::vector<bool> suppressed(boxes_num, false);
	int num_to_keep = 0;
    for (int i = 0; i < boxes_num; i++)
    {
        float x1min = boxes_host[i * boxes_dim];
        float y1min = boxes_host[i * boxes_dim + 1];
        float x1max = boxes_host[i * boxes_dim + 2];
        float y1max = boxes_host[i * boxes_dim + 3];

		Rectangle2D box1(x1min, y1min, x1max, y1max);

        if (suppressed[i])
            continue;

        keep_out[num_to_keep++] = i;

        for (auto j = i + 1; j < boxes_num; j++)
        {
            if (suppressed[j])
                continue;

            float x2min = boxes_host[j * boxes_dim];
            float y2min = boxes_host[j * boxes_dim + 1];
            float x2max = boxes_host[j * boxes_dim + 2];
            float y2max = boxes_host[j * boxes_dim + 3];

			Rectangle2D box2(x2min, y2min, x2max, y2max);

            float overlap = box1.Overlap(box2);
            float overlapRatio = overlap / (box1.Area() + box2.Area() - overlap);
            if (overlapRatio >= nms_overlap_thresh)
                suppressed[j] = true;
        }
    }

    *num_out = num_to_keep;
}