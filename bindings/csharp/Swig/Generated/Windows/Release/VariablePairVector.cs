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

public class VariablePairVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<VariablePair>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VariablePairVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VariablePairVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VariablePairVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_VariablePairVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VariablePairVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (VariablePair element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public VariablePair this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(VariablePair[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(VariablePair[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, VariablePair[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<VariablePair> global::System.Collections.Generic.IEnumerable<VariablePair>.GetEnumerator() {
    return new VariablePairVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new VariablePairVectorEnumerator(this);
  }

  public VariablePairVectorEnumerator GetEnumerator() {
    return new VariablePairVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class VariablePairVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<VariablePair>
  {
    private VariablePairVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public VariablePairVectorEnumerator(VariablePairVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public VariablePair Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (VariablePair)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    CNTKLibPINVOKE.VariablePairVector_Clear(swigCPtr);
  }

  public void Add(VariablePair x) {
    CNTKLibPINVOKE.VariablePairVector_Add(swigCPtr, VariablePair.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = CNTKLibPINVOKE.VariablePairVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = CNTKLibPINVOKE.VariablePairVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    CNTKLibPINVOKE.VariablePairVector_reserve(swigCPtr, n);
  }

  public VariablePairVector() : this(CNTKLibPINVOKE.new_VariablePairVector__SWIG_0(), true) {
  }

  public VariablePairVector(VariablePairVector other) : this(CNTKLibPINVOKE.new_VariablePairVector__SWIG_1(VariablePairVector.getCPtr(other)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public VariablePairVector(int capacity) : this(CNTKLibPINVOKE.new_VariablePairVector__SWIG_2(capacity), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private VariablePair getitemcopy(int index) {
    VariablePair ret = new VariablePair(CNTKLibPINVOKE.VariablePairVector_getitemcopy(swigCPtr, index), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private VariablePair getitem(int index) {
    VariablePair ret = new VariablePair(CNTKLibPINVOKE.VariablePairVector_getitem(swigCPtr, index), false);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, VariablePair val) {
    CNTKLibPINVOKE.VariablePairVector_setitem(swigCPtr, index, VariablePair.getCPtr(val));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(VariablePairVector values) {
    CNTKLibPINVOKE.VariablePairVector_AddRange(swigCPtr, VariablePairVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public VariablePairVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.VariablePairVector_GetRange(swigCPtr, index, count);
    VariablePairVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new VariablePairVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, VariablePair x) {
    CNTKLibPINVOKE.VariablePairVector_Insert(swigCPtr, index, VariablePair.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, VariablePairVector values) {
    CNTKLibPINVOKE.VariablePairVector_InsertRange(swigCPtr, index, VariablePairVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    CNTKLibPINVOKE.VariablePairVector_RemoveAt(swigCPtr, index);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    CNTKLibPINVOKE.VariablePairVector_RemoveRange(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static VariablePairVector Repeat(VariablePair value, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.VariablePairVector_Repeat(VariablePair.getCPtr(value), count);
    VariablePairVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new VariablePairVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    CNTKLibPINVOKE.VariablePairVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    CNTKLibPINVOKE.VariablePairVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, VariablePairVector values) {
    CNTKLibPINVOKE.VariablePairVector_SetRange(swigCPtr, index, VariablePairVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}