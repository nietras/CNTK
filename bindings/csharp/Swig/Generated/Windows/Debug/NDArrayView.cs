//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CNTK {

public partial class NDArrayView : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal NDArrayView(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NDArrayView obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NDArrayView() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          CNTKLibPINVOKE.delete_NDArrayView(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public NDArrayView(DataType dataType, NDShape viewShape, int[] colStarts, int[] rowIndices, SWIGTYPE_p_void nonZeroValues, uint numNonZeroValues, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_0((int)dataType, NDShape.getCPtr(viewShape), colStarts, rowIndices, SWIGTYPE_p_void.getCPtr(nonZeroValues), numNonZeroValues, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(DataType dataType, NDShape viewShape, int[] colStarts, int[] rowIndices, SWIGTYPE_p_void nonZeroValues, uint numNonZeroValues, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_1((int)dataType, NDShape.getCPtr(viewShape), colStarts, rowIndices, SWIGTYPE_p_void.getCPtr(nonZeroValues), numNonZeroValues, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(DataType dataType, StorageFormat storageType, NDShape viewShape, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_2((int)dataType, (int)storageType, NDShape.getCPtr(viewShape), DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(DataType dataType, NDShape viewShape, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_3((int)dataType, NDShape.getCPtr(viewShape), DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private DeviceDescriptor _Device() {
    DeviceDescriptor ret = new DeviceDescriptor(CNTKLibPINVOKE.NDArrayView__Device(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private DataType _GetDataType() {
    DataType ret = (DataType)CNTKLibPINVOKE.NDArrayView__GetDataType(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private StorageFormat _GetStorageFormat() {
    StorageFormat ret = (StorageFormat)CNTKLibPINVOKE.NDArrayView__GetStorageFormat(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDShape _Shape() {
    NDShape ret = new NDShape(CNTKLibPINVOKE.NDArrayView__Shape(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsSparse() {
    bool ret = CNTKLibPINVOKE.NDArrayView__IsSparse(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsReadOnly() {
    bool ret = CNTKLibPINVOKE.NDArrayView__IsReadOnly(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsSliceView() {
    bool ret = CNTKLibPINVOKE.NDArrayView__IsSliceView(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetValue(float value) {
    CNTKLibPINVOKE.NDArrayView_SetValue__SWIG_0(swigCPtr, value);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetValue(double value) {
    CNTKLibPINVOKE.NDArrayView_SetValue__SWIG_1(swigCPtr, value);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetValue(float16 value) {
    CNTKLibPINVOKE.NDArrayView_SetValue__SWIG_2(swigCPtr, float16.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetValue(SWIGTYPE_p_int8_t value) {
    CNTKLibPINVOKE.NDArrayView_SetValue__SWIG_3(swigCPtr, SWIGTYPE_p_int8_t.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetValue(SWIGTYPE_p_int16_t value) {
    CNTKLibPINVOKE.NDArrayView_SetValue__SWIG_4(swigCPtr, SWIGTYPE_p_int16_t.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView DeepClone(DeviceDescriptor device, bool readOnly) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView_DeepClone__SWIG_0(swigCPtr, DeviceDescriptor.getCPtr(device), readOnly);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDArrayView DeepClone(DeviceDescriptor device) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView_DeepClone__SWIG_1(swigCPtr, DeviceDescriptor.getCPtr(device));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDArrayView DeepClone(bool readOnly) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView_DeepClone__SWIG_2(swigCPtr, readOnly);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDArrayView DeepClone() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView_DeepClone__SWIG_3(swigCPtr);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDArrayView _Alias(bool readOnly) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__Alias__SWIG_0(swigCPtr, readOnly);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDArrayView _Alias() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__Alias__SWIG_1(swigCPtr);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDArrayView _SliceView(SizeTVector startOffset, SizeTVector extent, bool readOnly) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__SliceView__SWIG_0(swigCPtr, SizeTVector.getCPtr(startOffset), SizeTVector.getCPtr(extent), readOnly);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDArrayView _SliceView(SizeTVector startOffset, SizeTVector extent) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__SliceView__SWIG_1(swigCPtr, SizeTVector.getCPtr(startOffset), SizeTVector.getCPtr(extent));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDArrayView AsShape(NDShape newShape) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView_AsShape(swigCPtr, NDShape.getCPtr(newShape));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void CopyFrom(NDArrayView source) {
    CNTKLibPINVOKE.NDArrayView_CopyFrom(swigCPtr, NDArrayView.getCPtr(source));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ChangeDevice(DeviceDescriptor device) {
    CNTKLibPINVOKE.NDArrayView_ChangeDevice(swigCPtr, DeviceDescriptor.getCPtr(device));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public string AsString() {
    string ret = CNTKLibPINVOKE.NDArrayView_AsString(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDArrayView(NDShape viewShape, float[] dataBuffer, uint numBufferElements, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_14(NDShape.getCPtr(viewShape), dataBuffer, numBufferElements, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, float[] dataBuffer, uint numBufferElements, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_15(NDShape.getCPtr(viewShape), dataBuffer, numBufferElements, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, double[] dataBuffer, uint numBufferElements, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_16(NDShape.getCPtr(viewShape), dataBuffer, numBufferElements, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, double[] dataBuffer, uint numBufferElements, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_17(NDShape.getCPtr(viewShape), dataBuffer, numBufferElements, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, float[] nonZeroValues, uint numNonZeroValues, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_18(NDShape.getCPtr(viewShape), colStarts, rowIndices, nonZeroValues, numNonZeroValues, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, float[] nonZeroValues, uint numNonZeroValues, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_19(NDShape.getCPtr(viewShape), colStarts, rowIndices, nonZeroValues, numNonZeroValues, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, double[] nonZeroValues, uint numNonZeroValues, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_20(NDShape.getCPtr(viewShape), colStarts, rowIndices, nonZeroValues, numNonZeroValues, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, double[] nonZeroValues, uint numNonZeroValues, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_21(NDShape.getCPtr(viewShape), colStarts, rowIndices, nonZeroValues, numNonZeroValues, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, SWIGTYPE_p_int8_t nonZeroValues, uint numNonZeroValues, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_22(NDShape.getCPtr(viewShape), colStarts, rowIndices, SWIGTYPE_p_int8_t.getCPtr(nonZeroValues), numNonZeroValues, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, SWIGTYPE_p_int8_t nonZeroValues, uint numNonZeroValues, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_23(NDShape.getCPtr(viewShape), colStarts, rowIndices, SWIGTYPE_p_int8_t.getCPtr(nonZeroValues), numNonZeroValues, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, SWIGTYPE_p_int16_t nonZeroValues, uint numNonZeroValues, DeviceDescriptor device, bool readOnly) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_24(NDShape.getCPtr(viewShape), colStarts, rowIndices, SWIGTYPE_p_int16_t.getCPtr(nonZeroValues), numNonZeroValues, DeviceDescriptor.getCPtr(device), readOnly), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayView(NDShape viewShape, int[] colStarts, int[] rowIndices, SWIGTYPE_p_int16_t nonZeroValues, uint numNonZeroValues, DeviceDescriptor device) : this(CNTKLibPINVOKE.new_NDArrayView__SWIG_25(NDShape.getCPtr(viewShape), colStarts, rowIndices, SWIGTYPE_p_int16_t.getCPtr(nonZeroValues), numNonZeroValues, DeviceDescriptor.getCPtr(device)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private static NDArrayView _RandomNormalFloat(NDShape shape, double mean, double stdDev, uint seed, DeviceDescriptor device) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__RandomNormalFloat(NDShape.getCPtr(shape), mean, stdDev, seed, DeviceDescriptor.getCPtr(device));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static NDArrayView _RandomNormalDouble(NDShape shape, double mean, double stdDev, uint seed, DeviceDescriptor device) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__RandomNormalDouble(NDShape.getCPtr(shape), mean, stdDev, seed, DeviceDescriptor.getCPtr(device));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static NDArrayView _RandomUniformFloat(NDShape shape, double rangeStart, double rangeEnd, uint seed, DeviceDescriptor device) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__RandomUniformFloat(NDShape.getCPtr(shape), rangeStart, rangeEnd, seed, DeviceDescriptor.getCPtr(device));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static NDArrayView _RandomUniformDouble(NDShape shape, double rangeStart, double rangeEnd, uint seed, DeviceDescriptor device) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayView__RandomUniformDouble(NDShape.getCPtr(shape), rangeStart, rangeEnd, seed, DeviceDescriptor.getCPtr(device));
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
