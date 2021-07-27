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

public partial class Variable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Variable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Variable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Variable() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_Variable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Variable(Function function) : this(CNTKLibPINVOKE.new_Variable__SWIG_0(Function.getCPtr(function)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public Function ToFunction() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Variable_ToFunction(swigCPtr);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Variable() : this(CNTKLibPINVOKE.new_Variable__SWIG_1(), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private NDShape _Shape() {
    NDShape ret = new NDShape(CNTKLibPINVOKE.Variable__Shape(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private AxisVector _DynamicAxes() {
    AxisVector ret = new AxisVector(CNTKLibPINVOKE.Variable__DynamicAxes(swigCPtr), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariableKind _Kind() {
    VariableKind ret = (VariableKind)CNTKLibPINVOKE.Variable__Kind(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsSparse() {
    bool ret = CNTKLibPINVOKE.Variable__IsSparse(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsInput() {
    bool ret = CNTKLibPINVOKE.Variable__IsInput(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsOutput() {
    bool ret = CNTKLibPINVOKE.Variable__IsOutput(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsParameter() {
    bool ret = CNTKLibPINVOKE.Variable__IsParameter(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsConstant() {
    bool ret = CNTKLibPINVOKE.Variable__IsConstant(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsPlaceholder() {
    bool ret = CNTKLibPINVOKE.Variable__IsPlaceholder(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasBatchAxis() {
    bool ret = CNTKLibPINVOKE.Variable_HasBatchAxis(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasSequenceAxis() {
    bool ret = CNTKLibPINVOKE.Variable_HasSequenceAxis(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInitialized() {
    bool ret = CNTKLibPINVOKE.Variable_IsInitialized(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string _Name() {
    string ret = CNTKLibPINVOKE.Variable__Name(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string _Uid() {
    string ret = CNTKLibPINVOKE.Variable__Uid(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _Owner() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Variable__Owner(swigCPtr);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private DataType _GetDataType() {
    DataType ret = (DataType)CNTKLibPINVOKE.Variable__GetDataType(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _NeedsGradient() {
    bool ret = CNTKLibPINVOKE.Variable__NeedsGradient(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string AsString() {
    string ret = CNTKLibPINVOKE.Variable_AsString(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint _CurrentValueTimeStamp() {
    uint ret = CNTKLibPINVOKE.Variable__CurrentValueTimeStamp(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NDArrayView GetValue() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Variable_GetValue(swigCPtr);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Variable(NDShape shape, VariableKind varType, DataType dataType, NDArrayView value, bool needsGradient, AxisVector dynamicAxes, bool isSparse, string name, string uid) : this(CNTKLibPINVOKE.new_Variable__SWIG_3(NDShape.getCPtr(shape), (int)varType, (int)dataType, NDArrayView.getCPtr(value), needsGradient, AxisVector.getCPtr(dynamicAxes), isSparse, name, uid), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint _GetHashValue() {
    uint ret = CNTKLibPINVOKE.Variable__GetHashValue(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
