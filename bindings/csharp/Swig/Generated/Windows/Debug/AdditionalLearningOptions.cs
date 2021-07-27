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

public class AdditionalLearningOptions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AdditionalLearningOptions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AdditionalLearningOptions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AdditionalLearningOptions() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_AdditionalLearningOptions(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double l1RegularizationWeight {
    set {
      CNTKLibPINVOKE.AdditionalLearningOptions_l1RegularizationWeight_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CNTKLibPINVOKE.AdditionalLearningOptions_l1RegularizationWeight_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double l2RegularizationWeight {
    set {
      CNTKLibPINVOKE.AdditionalLearningOptions_l2RegularizationWeight_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CNTKLibPINVOKE.AdditionalLearningOptions_l2RegularizationWeight_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double gradientClippingThresholdPerSample {
    set {
      CNTKLibPINVOKE.AdditionalLearningOptions_gradientClippingThresholdPerSample_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      double ret = CNTKLibPINVOKE.AdditionalLearningOptions_gradientClippingThresholdPerSample_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool gradientClippingWithTruncation {
    set {
      CNTKLibPINVOKE.AdditionalLearningOptions_gradientClippingWithTruncation_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = CNTKLibPINVOKE.AdditionalLearningOptions_gradientClippingWithTruncation_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public CNTKDictionary dictOptions {
    set {
      CNTKLibPINVOKE.AdditionalLearningOptions_dictOptions_set(swigCPtr, CNTKDictionary.getCPtr(value));
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CNTKLibPINVOKE.AdditionalLearningOptions_dictOptions_get(swigCPtr);
      CNTKDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNTKDictionary(cPtr, false);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public AdditionalLearningOptions() : this(CNTKLibPINVOKE.new_AdditionalLearningOptions(), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
