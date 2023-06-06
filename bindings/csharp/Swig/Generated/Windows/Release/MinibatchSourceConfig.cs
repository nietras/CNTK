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

public partial class MinibatchSourceConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MinibatchSourceConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MinibatchSourceConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MinibatchSourceConfig() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_MinibatchSourceConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MinibatchSourceConfig(DictionaryVector deserializers, bool randomize) : this(CNTKLibPINVOKE.new_MinibatchSourceConfig__SWIG_0(DictionaryVector.getCPtr(deserializers), randomize), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public MinibatchSourceConfig(DictionaryVector deserializers) : this(CNTKLibPINVOKE.new_MinibatchSourceConfig__SWIG_1(DictionaryVector.getCPtr(deserializers)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint maxSamples {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_maxSamples_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_maxSamples_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint maxSweeps {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_maxSweeps_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_maxSweeps_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint randomizationWindowInChunks {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_randomizationWindowInChunks_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_randomizationWindowInChunks_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint randomizationWindowInSamples {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_randomizationWindowInSamples_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_randomizationWindowInSamples_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint randomizationSeed {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_randomizationSeed_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_randomizationSeed_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public TraceLevel traceLevel {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_traceLevel_set(swigCPtr, (int)value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      TraceLevel ret = (TraceLevel)CNTKLibPINVOKE.MinibatchSourceConfig_traceLevel_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint truncationLength {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_truncationLength_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_truncationLength_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool isFrameModeEnabled {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_isFrameModeEnabled_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = CNTKLibPINVOKE.MinibatchSourceConfig_isFrameModeEnabled_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DictionaryVector deserializers {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_deserializers_set(swigCPtr, DictionaryVector.getCPtr(value));
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = CNTKLibPINVOKE.MinibatchSourceConfig_deserializers_get(swigCPtr);
      DictionaryVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DictionaryVector(cPtr, false);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint maxErrors {
    set {
      CNTKLibPINVOKE.MinibatchSourceConfig_maxErrors_set(swigCPtr, value);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = CNTKLibPINVOKE.MinibatchSourceConfig_maxErrors_get(swigCPtr);
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ulong GetMaxSamples() {
    ulong ret = CNTKLibPINVOKE.MinibatchSourceConfig_GetMaxSamples(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxSamples(ulong i_maxSamples) {
    CNTKLibPINVOKE.MinibatchSourceConfig_SetMaxSamples(swigCPtr, i_maxSamples);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong GetMaxSweeps() {
    ulong ret = CNTKLibPINVOKE.MinibatchSourceConfig_GetMaxSweeps(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxSweeps(ulong i_maxSweeps) {
    CNTKLibPINVOKE.MinibatchSourceConfig_SetMaxSweeps(swigCPtr, i_maxSweeps);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}