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

public class NDArrayViewPtrVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<NDArrayView>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NDArrayViewPtrVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NDArrayViewPtrVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NDArrayViewPtrVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_NDArrayViewPtrVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public NDArrayViewPtrVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (NDArrayView element in c) {
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

  public NDArrayView this[int index]  {
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

  public void CopyTo(NDArrayView[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(NDArrayView[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, NDArrayView[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<NDArrayView> global::System.Collections.Generic.IEnumerable<NDArrayView>.GetEnumerator() {
    return new NDArrayViewPtrVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new NDArrayViewPtrVectorEnumerator(this);
  }

  public NDArrayViewPtrVectorEnumerator GetEnumerator() {
    return new NDArrayViewPtrVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class NDArrayViewPtrVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<NDArrayView>
  {
    private NDArrayViewPtrVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public NDArrayViewPtrVectorEnumerator(NDArrayViewPtrVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public NDArrayView Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (NDArrayView)currentObject;
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
    CNTKLibPINVOKE.NDArrayViewPtrVector_Clear(swigCPtr);
  }

  public void Add(NDArrayView x) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_Add(swigCPtr, NDArrayView.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = CNTKLibPINVOKE.NDArrayViewPtrVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = CNTKLibPINVOKE.NDArrayViewPtrVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_reserve(swigCPtr, n);
  }

  public NDArrayViewPtrVector() : this(CNTKLibPINVOKE.new_NDArrayViewPtrVector__SWIG_0(), true) {
  }

  public NDArrayViewPtrVector(NDArrayViewPtrVector other) : this(CNTKLibPINVOKE.new_NDArrayViewPtrVector__SWIG_1(NDArrayViewPtrVector.getCPtr(other)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayViewPtrVector(int capacity) : this(CNTKLibPINVOKE.new_NDArrayViewPtrVector__SWIG_2(capacity), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private NDArrayView getitemcopy(int index) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayViewPtrVector_getitemcopy(swigCPtr, index);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private NDArrayView getitem(int index) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayViewPtrVector_getitem(swigCPtr, index);
    NDArrayView ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayView(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, NDArrayView val) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_setitem(swigCPtr, index, NDArrayView.getCPtr(val));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(NDArrayViewPtrVector values) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_AddRange(swigCPtr, NDArrayViewPtrVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public NDArrayViewPtrVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayViewPtrVector_GetRange(swigCPtr, index, count);
    NDArrayViewPtrVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayViewPtrVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, NDArrayView x) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_Insert(swigCPtr, index, NDArrayView.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, NDArrayViewPtrVector values) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_InsertRange(swigCPtr, index, NDArrayViewPtrVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_RemoveAt(swigCPtr, index);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_RemoveRange(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static NDArrayViewPtrVector Repeat(NDArrayView value, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.NDArrayViewPtrVector_Repeat(NDArrayView.getCPtr(value), count);
    NDArrayViewPtrVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new NDArrayViewPtrVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    CNTKLibPINVOKE.NDArrayViewPtrVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, NDArrayViewPtrVector values) {
    CNTKLibPINVOKE.NDArrayViewPtrVector_SetRange(swigCPtr, index, NDArrayViewPtrVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(NDArrayView value) {
    bool ret = CNTKLibPINVOKE.NDArrayViewPtrVector_Contains(swigCPtr, NDArrayView.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(NDArrayView value) {
    int ret = CNTKLibPINVOKE.NDArrayViewPtrVector_IndexOf(swigCPtr, NDArrayView.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(NDArrayView value) {
    int ret = CNTKLibPINVOKE.NDArrayViewPtrVector_LastIndexOf(swigCPtr, NDArrayView.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(NDArrayView value) {
    bool ret = CNTKLibPINVOKE.NDArrayViewPtrVector_Remove(swigCPtr, NDArrayView.getCPtr(value));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
