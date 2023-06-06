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

public partial class Learner : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal Learner(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Learner obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Learner() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          CNTKLibPINVOKE.delete_Learner(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static string MinibatchSizeKey {
    get {
      string ret = CNTKLibPINVOKE.Learner_MinibatchSizeKey_get();
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static uint IgnoredMinibatchSize {
    get {
      uint ret = CNTKLibPINVOKE.Learner_IgnoredMinibatchSize_get();
      if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public virtual bool Update(UnorderedMapParameterNDArrayViewPtr gradientValues, uint trainingSampleCount, bool sweepEnd) {
    bool ret = CNTKLibPINVOKE.Learner_Update(swigCPtr, UnorderedMapParameterNDArrayViewPtr.getCPtr(gradientValues), trainingSampleCount, sweepEnd);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ParameterVector Parameters() {
    ParameterVector ret = new ParameterVector(CNTKLibPINVOKE.Learner_Parameters(swigCPtr), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual CNTKDictionary CreateCheckpoint() {
    CNTKDictionary ret = new CNTKDictionary(CNTKLibPINVOKE.Learner_CreateCheckpoint(swigCPtr), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void RestoreFromCheckpoint(CNTKDictionary arg0) {
    CNTKLibPINVOKE.Learner_RestoreFromCheckpoint(swigCPtr, CNTKDictionary.getCPtr(arg0));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint CurrentVersion() {
    uint ret = CNTKLibPINVOKE.Learner_CurrentVersion(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ResetLearningRate(TrainingParameterScheduleDouble learningRateSchedule) {
    CNTKLibPINVOKE.Learner_ResetLearningRate(swigCPtr, TrainingParameterScheduleDouble.getCPtr(learningRateSchedule));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ResetSmoothedGradients() {
    CNTKLibPINVOKE.Learner_ResetSmoothedGradients(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetNeedToUpdateMasterParameter() {
    CNTKLibPINVOKE.Learner_SetNeedToUpdateMasterParameter(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double LearningRate() {
    double ret = CNTKLibPINVOKE.Learner_LearningRate(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint TotalNumberOfSamplesSeen() {
    uint ret = CNTKLibPINVOKE.Learner_TotalNumberOfSamplesSeen(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint TotalNumberOfMinibatchesSeen() {
    uint ret = CNTKLibPINVOKE.Learner_TotalNumberOfMinibatchesSeen(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint TotalNumberOfSweepsSeen() {
    uint ret = CNTKLibPINVOKE.Learner_TotalNumberOfSweepsSeen(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddProgressWriters(ProgressWriterVector progressWriters) {
    CNTKLibPINVOKE.Learner_AddProgressWriters(swigCPtr, ProgressWriterVector.getCPtr(progressWriters));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMinibatchSize(uint minibatchSize) {
    CNTKLibPINVOKE.Learner_SetMinibatchSize(swigCPtr, minibatchSize);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetMinibatchSize() {
    uint ret = CNTKLibPINVOKE.Learner_GetMinibatchSize(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLearningRateSchedule(TrainingParameterScheduleDouble learningRateSchedule) {
    CNTKLibPINVOKE.Learner_SetLearningRateSchedule(swigCPtr, TrainingParameterScheduleDouble.getCPtr(learningRateSchedule));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public TrainingParameterScheduleDouble GetLearningRateSchedule() {
    TrainingParameterScheduleDouble ret = new TrainingParameterScheduleDouble(CNTKLibPINVOKE.Learner_GetLearningRateSchedule(swigCPtr), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsCompatibleMode() {
    bool ret = CNTKLibPINVOKE.Learner_IsCompatibleMode(swigCPtr);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}