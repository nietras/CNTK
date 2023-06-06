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

public partial class Axis : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Axis(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Axis obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Axis() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_Axis(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static AxisVector DefaultInputVariableDynamicAxes() {
    AxisVector ret = new AxisVector(CNTKLibPINVOKE.Axis_DefaultInputVariableDynamicAxes(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static AxisVector UnknownDynamicAxes() {
    AxisVector ret = new AxisVector(CNTKLibPINVOKE.Axis_UnknownDynamicAxes(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Axis(int staticAxisIdx) : this(CNTKLibPINVOKE.new_Axis__SWIG_0(staticAxisIdx), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public Axis(string name, bool isOrderedDynamicAxis) : this(CNTKLibPINVOKE.new_Axis__SWIG_1(name, isOrderedDynamicAxis), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public Axis(string name) : this(CNTKLibPINVOKE.new_Axis__SWIG_2(name), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private bool _IsStaticAxis() {
    bool ret = CNTKLibPINVOKE.Axis__IsStaticAxis(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsDynamicAxis() {
    bool ret = CNTKLibPINVOKE.Axis__IsDynamicAxis(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsBatchAxis() {
    bool ret = CNTKLibPINVOKE.Axis_IsBatchAxis(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsSequenceAxis() {
    bool ret = CNTKLibPINVOKE.Axis_IsSequenceAxis(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsOrdered() {
    bool ret = CNTKLibPINVOKE.Axis__IsOrdered(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private int _StaticAxisIndex(bool arg0) {
    int ret = CNTKLibPINVOKE.Axis__StaticAxisIndex__SWIG_0(swigCPtr, arg0);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private int _StaticAxisIndex() {
    int ret = CNTKLibPINVOKE.Axis__StaticAxisIndex__SWIG_1(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis DefaultDynamicAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_DefaultDynamicAxis(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis OperandSequenceAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_OperandSequenceAxis(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis DefaultBatchAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_DefaultBatchAxis(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis AllStaticAxes() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_AllStaticAxes(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis AllAxes() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_AllAxes(), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis NewUniqueDynamicAxis(string axisNamePrefix, bool isOrderedDynamicAxis) {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_NewUniqueDynamicAxis__SWIG_0(axisNamePrefix, isOrderedDynamicAxis), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis NewUniqueDynamicAxis(string axisNamePrefix) {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_NewUniqueDynamicAxis__SWIG_1(axisNamePrefix), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis EndStaticAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_EndStaticAxis(), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string _Name() {
    string ret = CNTKLibPINVOKE.Axis__Name(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string AsString() {
    string ret = CNTKLibPINVOKE.Axis_AsString(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Axis() : this(CNTKLibPINVOKE.new_Axis__SWIG_3(), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}