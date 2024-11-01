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

public partial class Function : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Function(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Function obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Function() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          CNTKLibPINVOKE.delete_Function(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void PrintNodeTiming() {
    CNTKLibPINVOKE.Function_PrintNodeTiming(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private string _OpName() {
    string ret = CNTKLibPINVOKE.Function__OpName(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint _CurrentVersion() {
    uint ret = CNTKLibPINVOKE.Function__CurrentVersion(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _Clone(VariableVector arg0) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Clone__SWIG_0(swigCPtr, VariableVector.getCPtr(arg0));
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void _Evaluate(UnorderedMapVariableValuePtr arguments, UnorderedMapVariableValuePtr outputs, DeviceDescriptor computeDevice) {
    CNTKLibPINVOKE.Function__Evaluate__SWIG_0(swigCPtr, UnorderedMapVariableValuePtr.getCPtr(arguments), UnorderedMapVariableValuePtr.getCPtr(outputs), DeviceDescriptor.getCPtr(computeDevice));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private void _Evaluate(UnorderedMapVariableValuePtr arguments, UnorderedMapVariableValuePtr outputs) {
    CNTKLibPINVOKE.Function__Evaluate__SWIG_1(swigCPtr, UnorderedMapVariableValuePtr.getCPtr(arguments), UnorderedMapVariableValuePtr.getCPtr(outputs));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private Function _Clone(ParameterCloningMethod parameterCloneMethod, UnorderedMapVariableVariable replacements) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Clone__SWIG_1(swigCPtr, (int)parameterCloneMethod, UnorderedMapVariableVariable.getCPtr(replacements));
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _Clone(ParameterCloningMethod parameterCloneMethod) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Clone__SWIG_2(swigCPtr, (int)parameterCloneMethod);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _Clone() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Clone__SWIG_3(swigCPtr);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Function CloneFlattened(ParameterCloningMethod parameterCloneMethod) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function_CloneFlattened__SWIG_0(swigCPtr, (int)parameterCloneMethod);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Function CloneFlattened() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function_CloneFlattened__SWIG_1(swigCPtr);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string _Name() {
    string ret = CNTKLibPINVOKE.Function__Name(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string name) {
    CNTKLibPINVOKE.Function_SetName(swigCPtr, name);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private string _Uid() {
    string ret = CNTKLibPINVOKE.Function__Uid(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _RootFunction() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__RootFunction(swigCPtr);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsComposite() {
    bool ret = CNTKLibPINVOKE.Function__IsComposite(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsPrimitive() {
    bool ret = CNTKLibPINVOKE.Function__IsPrimitive(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool _IsBlock() {
    bool ret = CNTKLibPINVOKE.Function__IsBlock(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Function BlockRoot() {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function_BlockRoot(swigCPtr);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VariablePairVector BlockArgumentsMapping() {
    VariablePairVector ret = new VariablePairVector(CNTKLibPINVOKE.Function_BlockArgumentsMapping(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariableVector _Inputs(bool pythonOperandOrder) {
    VariableVector ret = new VariableVector(CNTKLibPINVOKE.Function__Inputs__SWIG_0(swigCPtr, pythonOperandOrder), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariableVector _Inputs() {
    VariableVector ret = new VariableVector(CNTKLibPINVOKE.Function__Inputs__SWIG_1(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Variable _Output() {
    Variable ret = new Variable(CNTKLibPINVOKE.Function__Output(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariableVector _Outputs() {
    VariableVector ret = new VariableVector(CNTKLibPINVOKE.Function__Outputs(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariableVector _Arguments(bool rowMajor) {
    VariableVector ret = new VariableVector(CNTKLibPINVOKE.Function__Arguments__SWIG_0(swigCPtr, rowMajor), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariableVector _Arguments() {
    VariableVector ret = new VariableVector(CNTKLibPINVOKE.Function__Arguments__SWIG_1(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private ParameterVector _Parameters() {
    ParameterVector ret = new ParameterVector(CNTKLibPINVOKE.Function__Parameters(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ConstantVector Constants() {
    ConstantVector ret = new ConstantVector(CNTKLibPINVOKE.Function_Constants(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VariableVector Placeholders() {
    VariableVector ret = new VariableVector(CNTKLibPINVOKE.Function_Placeholders(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _FindByName(string name, bool nestedSearchInsideBlockFunction) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__FindByName__SWIG_0(swigCPtr, name, nestedSearchInsideBlockFunction);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Function _FindByName(string name) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__FindByName__SWIG_1(swigCPtr, name);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private FunctionPtrVector _FindAllWithName(string name, bool nestedSearchInsideBlockFunction) {
    FunctionPtrVector ret = new FunctionPtrVector(CNTKLibPINVOKE.Function__FindAllWithName__SWIG_0(swigCPtr, name, nestedSearchInsideBlockFunction), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private FunctionPtrVector _FindAllWithName(string name) {
    FunctionPtrVector ret = new FunctionPtrVector(CNTKLibPINVOKE.Function__FindAllWithName__SWIG_1(swigCPtr, name), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNTKDictionary Attributes() {
    CNTKDictionary ret = new CNTKDictionary(CNTKLibPINVOKE.Function_Attributes(swigCPtr), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Function ReplacePlaceholders(UnorderedMapVariableVariable placeholderReplacements) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function_ReplacePlaceholders(swigCPtr, UnorderedMapVariableVariable.getCPtr(placeholderReplacements));
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Function ReplacePlaceholder(Variable placeholderReplacement) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function_ReplacePlaceholder(swigCPtr, Variable.getCPtr(placeholderReplacement));
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void _Save(UnsignedCharVector vectorBuf) {
    CNTKLibPINVOKE.Function__Save__SWIG_0(swigCPtr, UnsignedCharVector.getCPtr(vectorBuf));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private void _Save(string filepath, ModelFormat format, bool useExternalFilesToStoreParameters) {
    CNTKLibPINVOKE.Function__Save__SWIG_1(swigCPtr, filepath, (int)format, useExternalFilesToStoreParameters);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private void _Save(string filepath, ModelFormat format) {
    CNTKLibPINVOKE.Function__Save__SWIG_2(swigCPtr, filepath, (int)format);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private void _Save(string filepath) {
    CNTKLibPINVOKE.Function__Save__SWIG_3(swigCPtr, filepath);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Restore(string filepath) {
    CNTKLibPINVOKE.Function_Restore(swigCPtr, filepath);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private static Function _Load(string filepath, DeviceDescriptor computeDevice, ModelFormat format) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Load__SWIG_0(filepath, DeviceDescriptor.getCPtr(computeDevice), (int)format);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static Function _Load(string filepath, DeviceDescriptor computeDevice) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Load__SWIG_1(filepath, DeviceDescriptor.getCPtr(computeDevice));
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static Function _Load(string filepath) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Load__SWIG_2(filepath);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static Function _Load(byte[] buffer, uint length, DeviceDescriptor computeDevice, ModelFormat format) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Load__SWIG_3(buffer, length, DeviceDescriptor.getCPtr(computeDevice), (int)format);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static Function _Load(byte[] buffer, uint length, DeviceDescriptor computeDevice) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Load__SWIG_4(buffer, length, DeviceDescriptor.getCPtr(computeDevice));
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private static Function _Load(byte[] buffer, uint length) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.Function__Load__SWIG_5(buffer, length);
    Function ret = (cPtr == global::System.IntPtr.Zero) ? null : new Function(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string AsString(bool doNotInferOutputs) {
    string ret = CNTKLibPINVOKE.Function_AsString__SWIG_0(swigCPtr, doNotInferOutputs);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string AsString() {
    string ret = CNTKLibPINVOKE.Function_AsString__SWIG_1(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CNTKDictionary GetCustomAttributes() {
    CNTKDictionary ret = new CNTKDictionary(CNTKLibPINVOKE.Function_GetCustomAttributes(swigCPtr), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ResetCustomAttributes() {
    CNTKLibPINVOKE.Function_ResetCustomAttributes(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static readonly int MaxNumOutputs = CNTKLibPINVOKE.Function_MaxNumOutputs_get();
}

}
