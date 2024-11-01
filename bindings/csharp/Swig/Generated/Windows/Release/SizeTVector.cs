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

public class SizeTVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<uint>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SizeTVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SizeTVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SizeTVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_SizeTVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SizeTVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (uint element in c) {
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

  public uint this[int index]  {
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

  public void CopyTo(uint[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(uint[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, uint[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<uint> global::System.Collections.Generic.IEnumerable<uint>.GetEnumerator() {
    return new SizeTVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new SizeTVectorEnumerator(this);
  }

  public SizeTVectorEnumerator GetEnumerator() {
    return new SizeTVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class SizeTVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<uint>
  {
    private SizeTVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public SizeTVectorEnumerator(SizeTVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public uint Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (uint)currentObject;
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
    CNTKLibPINVOKE.SizeTVector_Clear(swigCPtr);
  }

  public void Add(uint x) {
    CNTKLibPINVOKE.SizeTVector_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = CNTKLibPINVOKE.SizeTVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = CNTKLibPINVOKE.SizeTVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    CNTKLibPINVOKE.SizeTVector_reserve(swigCPtr, n);
  }

  public SizeTVector() : this(CNTKLibPINVOKE.new_SizeTVector__SWIG_0(), true) {
  }

  public SizeTVector(SizeTVector other) : this(CNTKLibPINVOKE.new_SizeTVector__SWIG_1(SizeTVector.getCPtr(other)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public SizeTVector(int capacity) : this(CNTKLibPINVOKE.new_SizeTVector__SWIG_2(capacity), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint getitemcopy(int index) {
    uint ret = CNTKLibPINVOKE.SizeTVector_getitemcopy(swigCPtr, index);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint getitem(int index) {
    uint ret = CNTKLibPINVOKE.SizeTVector_getitem(swigCPtr, index);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, uint val) {
    CNTKLibPINVOKE.SizeTVector_setitem(swigCPtr, index, val);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(SizeTVector values) {
    CNTKLibPINVOKE.SizeTVector_AddRange(swigCPtr, SizeTVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public SizeTVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.SizeTVector_GetRange(swigCPtr, index, count);
    SizeTVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SizeTVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, uint x) {
    CNTKLibPINVOKE.SizeTVector_Insert(swigCPtr, index, x);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, SizeTVector values) {
    CNTKLibPINVOKE.SizeTVector_InsertRange(swigCPtr, index, SizeTVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    CNTKLibPINVOKE.SizeTVector_RemoveAt(swigCPtr, index);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    CNTKLibPINVOKE.SizeTVector_RemoveRange(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public static SizeTVector Repeat(uint value, int count) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.SizeTVector_Repeat(value, count);
    SizeTVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SizeTVector(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    CNTKLibPINVOKE.SizeTVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    CNTKLibPINVOKE.SizeTVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, SizeTVector values) {
    CNTKLibPINVOKE.SizeTVector_SetRange(swigCPtr, index, SizeTVector.getCPtr(values));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(uint value) {
    bool ret = CNTKLibPINVOKE.SizeTVector_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(uint value) {
    int ret = CNTKLibPINVOKE.SizeTVector_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(uint value) {
    int ret = CNTKLibPINVOKE.SizeTVector_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(uint value) {
    bool ret = CNTKLibPINVOKE.SizeTVector_Remove(swigCPtr, value);
    return ret;
  }

}

}
