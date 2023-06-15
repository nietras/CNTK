// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CNTK.V2LibraryCSTests
{
    [TestClass]
    public class FunctionTests
    {
        [TestMethod]
        public void TestSaveAndLoad()
        {
            int channels = 2;
            int imageWidth = 32, imageHeight = 16;
            int[] inputDim = { imageHeight, imageWidth, channels };
            Variable input = CNTKLib.InputVariable(inputDim, DataType.Float, "Images");
            Parameter param = new Parameter(inputDim, DataType.Float, CNTKLib.GlorotUniformInitializer(0.1F, 1, 0), DeviceDescriptor.CPUDevice);
            Function model = CNTKLib.Plus(input, param, "Plus");
            byte[] buffer = model.Save();
            Function loadedModel = Function.Load(buffer, DeviceDescriptor.CPUDevice);
            Assert.AreEqual(model.Name, loadedModel.Name);
            Assert.AreEqual(model.Inputs.Count, loadedModel.Inputs.Count);
            Assert.AreEqual(model.Inputs[0].Shape, loadedModel.Inputs[0].Shape);
            Assert.AreEqual(model.Output.Shape, loadedModel.Output.Shape);
        }

        [TestMethod]
        public void TestSaveAndLoadToFile()
        {
            int channels = 2;
            int imageWidth = 32, imageHeight = 16;
            int[] inputDim = { imageHeight, imageWidth, channels };
            Variable input = CNTKLib.InputVariable(inputDim, DataType.Float, "Images");
            Parameter param = new Parameter(inputDim, DataType.Float, CNTKLib.GlorotUniformInitializer(0.1F, 1, 0), DeviceDescriptor.CPUDevice);
            Function model = CNTKLib.Plus(input, param, "Plus");
            string savedFileName = "./TestSaveAndLoadToFileSavedModel.txt";
            model.Save(savedFileName);
            Function loadedModel = Function.Load(savedFileName, DeviceDescriptor.CPUDevice);
            File.Delete(savedFileName);
            Assert.AreEqual(model.Name, loadedModel.Name);
            Assert.AreEqual(model.Inputs.Count, loadedModel.Inputs.Count);
            Assert.AreEqual(model.Inputs[0].Shape, loadedModel.Inputs[0].Shape);
            Assert.AreEqual(model.Output.Shape, loadedModel.Output.Shape);
        }

        [TestMethod]
        public void TestSaveAndLoadToFileOnnx()
        {
            int channels = 2;
            int imageWidth = 32;
            var imageHeight = 16;
            int[] inputDim = { imageHeight, imageWidth, channels };
            int[] expectedOnnxDims = { imageHeight, imageWidth, channels, 1, -3 };
            Variable input = CNTKLib.InputVariable(inputDim, DataType.Float, "Images");
            Parameter param = new Parameter(inputDim, DataType.Float, CNTKLib.GlorotUniformInitializer(0.1F, 1, 0), DeviceDescriptor.CPUDevice);
            Function model = CNTKLib.Plus(input, param, "Plus");
            const string fileName = nameof(TestSaveAndLoadToFileOnnx) + ".onnx";
            var format = ModelFormat.ONNX;
            model.Save(fileName, format);
            Function loadedModel = Function.Load(fileName, DeviceDescriptor.CPUDevice, format);
            Assert.AreEqual(model.Name, loadedModel.Name);
            Assert.AreEqual(model.Inputs.Count, loadedModel.Inputs.Count);
            CollectionAssert.AreEqual(expectedOnnxDims, loadedModel.Inputs[0].Shape.Dimensions.ToArray());
            CollectionAssert.AreEqual(expectedOnnxDims, loadedModel.Output.Shape.Dimensions.ToArray());
        }

        [TestMethod]
        public void TestSetAndGetRandomSeed()
        {
            uint expectedRandomSeed = 20;
            uint randomSeed = expectedRandomSeed;
            CNTKLib.SetFixedRandomSeed(randomSeed);
            var isSeedFixed = CNTKLib.IsRandomSeedFixed();
            var retrievedRandomSeed = CNTKLib.GetRandomSeed();
            Assert.AreEqual(true, isSeedFixed);
            Assert.AreEqual(expectedRandomSeed, retrievedRandomSeed);
        }

        [TestMethod]
        public void TestForceDeterministicAlgorithms()
        {
            CNTKLib.ForceDeterministicAlgorithms();
            var shouldForce = CNTKLib.ShouldForceDeterministicAlgorithms();
            Assert.AreEqual(true, shouldForce);
        }

    }
}
