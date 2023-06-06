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

public partial class NDShape : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal NDShape(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NDShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NDShape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          CNTKLibPINVOKE.delete_NDShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static NDShape Unknown() {
    NDShape ret = new NDShape(CNTKLibPINVOKE.NDShape_Unknown(), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDShape() : this(CNTKLibPINVOKE.new_NDShape__SWIG_0(), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDShape(uint numAxes, uint dimension) : this(CNTKLibPINVOKE.new_NDShape__SWIG_1(numAxes, dimension), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDShape(uint numAxes) : this(CNTKLibPINVOKE.new_NDShape__SWIG_2(numAxes), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDShape(SizeTVector dimensions) : this(CNTKLibPINVOKE.new_NDShape__SWIG_3(SizeTVector.getCPtr(dimensions)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private SizeTVector _Dimensions() {
    SizeTVector ret = new SizeTVector(CNTKLibPINVOKE.NDShape__Dimensions(swigCPtr), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsUnknown() {
    bool ret = CNTKLibPINVOKE.NDShape__IsUnknown(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsScalar() {
    bool ret = CNTKLibPINVOKE.NDShape_IsScalar(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint _Rank() {
    uint ret = CNTKLibPINVOKE.NDShape__Rank(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDShape _SubShape(uint beginAxisId, uint endAxisId) {
    NDShape ret = new NDShape(CNTKLibPINVOKE.NDShape__SubShape__SWIG_0(swigCPtr, beginAxisId, endAxisId), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDShape _SubShape(uint beginAxisId) {
    NDShape ret = new NDShape(CNTKLibPINVOKE.NDShape__SubShape__SWIG_1(swigCPtr, beginAxisId), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDShape _SubShape() {
    NDShape ret = new NDShape(CNTKLibPINVOKE.NDShape__SubShape__SWIG_2(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _HasInferredDimension() {
    bool ret = CNTKLibPINVOKE.NDShape__HasInferredDimension(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _HasFreeDimension() {
    bool ret = CNTKLibPINVOKE.NDShape__HasFreeDimension(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _HasUnboundDimension() {
    bool ret = CNTKLibPINVOKE.NDShape__HasUnboundDimension(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint _TotalSize() {
    uint ret = CNTKLibPINVOKE.NDShape__TotalSize(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDShape AppendShape(NDShape shape) {
    NDShape ret = new NDShape(CNTKLibPINVOKE.NDShape_AppendShape(swigCPtr, NDShape.getCPtr(shape)), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string AsString() {
    string ret = CNTKLibPINVOKE.NDShape_AsString(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint _DimensionSize(uint axisId) {
    uint ret = CNTKLibPINVOKE.NDShape__DimensionSize(swigCPtr, axisId);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void CSharp_SizeTVector_AddExt(SizeTVector vectorSizeT, ulong dim) {
    CNTKLibPINVOKE.NDShape_CSharp_SizeTVector_AddExt(SizeTVector.getCPtr(vectorSizeT), dim);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }


}

}