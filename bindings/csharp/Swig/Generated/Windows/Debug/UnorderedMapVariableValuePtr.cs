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

public class UnorderedMapVariableValuePtr : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<Variable, Value>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UnorderedMapVariableValuePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UnorderedMapVariableValuePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UnorderedMapVariableValuePtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_UnorderedMapVariableValuePtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


    public Value this[Variable key]
    {
        get 
        {
            return getitem(key);
        }

        set 
        {
            setitem(key, value);
        }
    }

    public bool TryGetValue(Variable key, out Value value) 
    {
        if (this.ContainsKey(key)) 
        {
            value = this[key];
            return true;
        }
        value = default(Value);
        return false;
    }

    public int Count 
    {
        get 
        {
            return (int)size();
        }
    }

    public bool IsReadOnly 
    {
        get 
        { 
            return false; 
        }
    }

    public global::System.Collections.Generic.ICollection<Variable> Keys 
    {
        get 
        {
            global::System.Collections.Generic.ICollection<Variable> keys = new global::System.Collections.Generic.List<Variable>();
            int size = this.Count;
            if (size > 0) 
            {
                global::System.IntPtr iter = create_iterator_begin();
                for (int i = 0; i < size; i++) 
                {
                    keys.Add(get_next_key(iter));
                }
                destroy_iterator(iter);
            }
            return keys;
        }
    }

    public global::System.Collections.Generic.ICollection<Value> Values 
    {
        get 
        {
            global::System.Collections.Generic.ICollection<Value> vals = new global::System.Collections.Generic.List<Value>();
            foreach (global::System.Collections.Generic.KeyValuePair<Variable, Value> pair in this) 
            {
                vals.Add(pair.Value);
            }
            return vals;
        }
    }
  
    public void Add(global::System.Collections.Generic.KeyValuePair<Variable, Value> item) 
    {
        Add(item.Key, item.Value);
    }

    public bool Remove(global::System.Collections.Generic.KeyValuePair<Variable, Value> item) 
    {
        if (Contains(item)) 
        {
            return Remove(item.Key);
        } 
        else 
        {
            return false;
        }
    }

    public bool Contains(global::System.Collections.Generic.KeyValuePair<Variable, Value> item) 
    {
        if (this[item.Key] == item.Value) 
        {
            return true;
        } 
        else
        {
            return false;
        }
    }

    public void CopyTo(global::System.Collections.Generic.KeyValuePair<Variable, Value>[] array) 
    {
        CopyTo(array, 0);
    }

    public void CopyTo(global::System.Collections.Generic.KeyValuePair<Variable, Value>[] array, int arrayIndex) 
    {
        if (array == null)
        {
            throw new global::System.ArgumentNullException("array");
        }
    
        if (arrayIndex < 0)
        {
            throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
        }
        if (array.Rank > 1) 
        {
            throw new global::System.ArgumentException("Multi dimensional array.", "array");
        }
        if (arrayIndex+this.Count > array.Length)
        {
            throw new global::System.ArgumentException("Number of elements to copy is too large.");
        }

        global::System.Collections.Generic.IList<Variable> keyList = new global::System.Collections.Generic.List<Variable>(this.Keys);
        for (int i = 0; i < keyList.Count; i++)
        {
            Variable currentKey = keyList[i];
            array.SetValue(new global::System.Collections.Generic.KeyValuePair<Variable, Value>(currentKey, this[currentKey]), arrayIndex+i);
        }
    }

    global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<Variable, Value>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<Variable, Value>>.GetEnumerator() 
    {
        return new UnorderedMapVariableValuePtrEnumerator(this);
    }

    global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() 
    {
        return new UnorderedMapVariableValuePtrEnumerator(this);
    }

    public UnorderedMapVariableValuePtrEnumerator GetEnumerator() 
    {
        return new UnorderedMapVariableValuePtrEnumerator(this);
    }

    // Type-safe enumerator
    /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
    /// whenever the collection is modified. This has been done for changes in the size of the
    /// collection but not when one of the elements of the collection is modified as it is a bit
    /// tricky to detect unmanaged code that modifies the collection under our feet.
    public sealed class UnorderedMapVariableValuePtrEnumerator : global::System.Collections.IEnumerator, 
        global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<Variable, Value>>
    {
        private UnorderedMapVariableValuePtr collectionRef;
        private global::System.Collections.Generic.IList<Variable> keyCollection;
        private int currentIndex;
        private object currentObject;
        private int currentSize;

        public UnorderedMapVariableValuePtrEnumerator(UnorderedMapVariableValuePtr collection) 
        {
            collectionRef = collection;
            keyCollection = new global::System.Collections.Generic.List<Variable>(collection.Keys);
            currentIndex = -1;
            currentObject = null;
            currentSize = collectionRef.Count;
        }

        // Type-safe iterator Current
        public global::System.Collections.Generic.KeyValuePair<Variable, Value> Current 
        {
            get 
            {
                if (currentIndex == -1)
                {
                    throw new global::System.InvalidOperationException("Enumeration not started.");
                }
                if (currentIndex > currentSize - 1)
                {
                    throw new global::System.InvalidOperationException("Enumeration finished.");
                }
                if (currentObject == null)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
                return (global::System.Collections.Generic.KeyValuePair<Variable, Value>)currentObject;
            }
        }

        // Type-unsafe IEnumerator.Current
        object global::System.Collections.IEnumerator.Current
        {
            get 
            {
                return Current;
            }
        }

        public bool MoveNext() 
        {
            int size = collectionRef.Count;
            bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
            if (moveOkay) 
            {
                currentIndex++;
                Variable currentKey = keyCollection[currentIndex];
                currentObject = new global::System.Collections.Generic.KeyValuePair<Variable, Value>(currentKey, collectionRef[currentKey]);
            } 
            else 
            {
                currentObject = null;
            }
            return moveOkay;
        }

        public void Reset() 
        {
            currentIndex = -1;
            currentObject = null;
            if (collectionRef.Count != currentSize) 
            {
                throw new global::System.InvalidOperationException("Collection modified.");
            }
        }

        public void Dispose() 
        {
            currentIndex = -1;
            currentObject = null;
        }
    }
  

  public UnorderedMapVariableValuePtr() : this(CNTKLibPINVOKE.new_UnorderedMapVariableValuePtr__SWIG_0(), true) {
  }

  public UnorderedMapVariableValuePtr(UnorderedMapVariableValuePtr other) : this(CNTKLibPINVOKE.new_UnorderedMapVariableValuePtr__SWIG_1(UnorderedMapVariableValuePtr.getCPtr(other)), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = CNTKLibPINVOKE.UnorderedMapVariableValuePtr_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = CNTKLibPINVOKE.UnorderedMapVariableValuePtr_empty(swigCPtr);
    return ret;
  }

  public void Clear() {
    CNTKLibPINVOKE.UnorderedMapVariableValuePtr_Clear(swigCPtr);
  }

  private Value getitem(Variable key) {
    global::System.IntPtr cPtr = CNTKLibPINVOKE.UnorderedMapVariableValuePtr_getitem(swigCPtr, Variable.getCPtr(key));
    Value ret = (cPtr == global::System.IntPtr.Zero) ? null : new Value(cPtr, true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(Variable key, Value x) {
    CNTKLibPINVOKE.UnorderedMapVariableValuePtr_setitem(swigCPtr, Variable.getCPtr(key), Value.getCPtr(x));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(Variable key) {
    bool ret = CNTKLibPINVOKE.UnorderedMapVariableValuePtr_ContainsKey(swigCPtr, Variable.getCPtr(key));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(Variable key, Value val) {
    CNTKLibPINVOKE.UnorderedMapVariableValuePtr_Add(swigCPtr, Variable.getCPtr(key), Value.getCPtr(val));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(Variable key) {
    bool ret = CNTKLibPINVOKE.UnorderedMapVariableValuePtr_Remove(swigCPtr, Variable.getCPtr(key));
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = CNTKLibPINVOKE.UnorderedMapVariableValuePtr_create_iterator_begin(swigCPtr);
    return ret;
  }

  private Variable get_next_key(global::System.IntPtr swigiterator) {
    Variable ret = new Variable(CNTKLibPINVOKE.UnorderedMapVariableValuePtr_get_next_key(swigCPtr, swigiterator), false);
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    CNTKLibPINVOKE.UnorderedMapVariableValuePtr_destroy_iterator(swigCPtr, swigiterator);
  }

}

}
