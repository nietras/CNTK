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

public class PairFloatFloat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PairFloatFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PairFloatFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PairFloatFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_PairFloatFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PairFloatFloat() : this(CNTKLibPINVOKE.new_PairFloatFloat__SWIG_0(), true) {
  }

  public PairFloatFloat(float t, float u) : this(CNTKLibPINVOKE.new_PairFloatFloat__SWIG_1(t, u), true) {
  }

  public PairFloatFloat(PairFloatFloat p) : this(CNTKLibPINVOKE.new_PairFloatFloat__SWIG_2(PairFloatFloat.getCPtr(p)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public float first {
    set {
      CNTKLibPINVOKE.PairFloatFloat_first_set(swigCPtr, value);
    } 
    get {
      float ret = CNTKLibPINVOKE.PairFloatFloat_first_get(swigCPtr);
      return ret;
    } 
  }

  public float second {
    set {
      CNTKLibPINVOKE.PairFloatFloat_second_set(swigCPtr, value);
    } 
    get {
      float ret = CNTKLibPINVOKE.PairFloatFloat_second_get(swigCPtr);
      return ret;
    } 
  }

}

}
