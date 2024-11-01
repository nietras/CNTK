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

public class CNTKDictionary : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNTKDictionary(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNTKDictionary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNTKDictionary() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_CNTKDictionary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CNTKDictionary() : this(CNTKLibPINVOKE.new_CNTKDictionary__SWIG_0(), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CNTKDictionary(CNTKDictionary arg0) : this(CNTKLibPINVOKE.new_CNTKDictionary__SWIG_1(CNTKDictionary.getCPtr(arg0)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CNTKDictionary Equal(CNTKDictionary arg0) {
    CNTKDictionary ret = new CNTKDictionary(CNTKLibPINVOKE.CNTKDictionary_Equal(swigCPtr, CNTKDictionary.getCPtr(arg0)), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Contains(string key) {
    bool ret = CNTKLibPINVOKE.CNTKDictionary_Contains(swigCPtr, key);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(CNTKDictionary other) {
    CNTKLibPINVOKE.CNTKDictionary_Add__SWIG_0(swigCPtr, CNTKDictionary.getCPtr(other));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(string key, DictionaryValue value) {
    CNTKLibPINVOKE.CNTKDictionary_Add__SWIG_1(swigCPtr, key, DictionaryValue.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool AreEqual(CNTKDictionary other) {
    bool ret = CNTKLibPINVOKE.CNTKDictionary_AreEqual(swigCPtr, CNTKDictionary.getCPtr(other));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AreNotEqual(CNTKDictionary other) {
    bool ret = CNTKLibPINVOKE.CNTKDictionary_AreNotEqual(swigCPtr, CNTKDictionary.getCPtr(other));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Size() {
    uint ret = CNTKLibPINVOKE.CNTKDictionary_Size(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Save(string filename) {
    CNTKLibPINVOKE.CNTKDictionary_Save(swigCPtr, filename);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static CNTKDictionary Load(string filename) {
    CNTKDictionary ret = new CNTKDictionary(CNTKLibPINVOKE.CNTKDictionary_Load(filename), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
