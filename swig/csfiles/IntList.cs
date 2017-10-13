//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace LandmarkDetector
{

    public class IntList : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IList<int>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal IntList(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntList obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~IntList()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock(this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        LandmarkDetectorPINVOKE.delete_IntList(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public IntList(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (int element in c)
            {
                this.Add(element);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public int this[int index]
        {
            get
            {
                return getitem(index);
            }
            set
            {
                setitem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return (int)capacity();
            }
            set
            {
                if (value < size())
                    throw new global::System.ArgumentOutOfRangeException("Capacity");
                reserve((uint)value);
            }
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public void CopyTo(int[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, int[] array, int arrayIndex, int count)
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

        global::System.Collections.Generic.IEnumerator<int> global::System.Collections.Generic.IEnumerable<int>.GetEnumerator()
        {
            return new IntListEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new IntListEnumerator(this);
        }

        public IntListEnumerator GetEnumerator()
        {
            return new IntListEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class IntListEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<int>
        {
            private IntList collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public IntListEnumerator(IntList collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public int Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (int)currentObject;
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
                    currentObject = collectionRef[currentIndex];
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

        public void Clear()
        {
            LandmarkDetectorPINVOKE.IntList_Clear(swigCPtr);
        }

        public void Add(int x)
        {
            LandmarkDetectorPINVOKE.IntList_Add(swigCPtr, x);
        }

        private uint size()
        {
            uint ret = LandmarkDetectorPINVOKE.IntList_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = LandmarkDetectorPINVOKE.IntList_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            LandmarkDetectorPINVOKE.IntList_reserve(swigCPtr, n);
        }

        public IntList() : this(LandmarkDetectorPINVOKE.new_IntList__SWIG_0(), true)
        {
        }

        public IntList(IntList other) : this(LandmarkDetectorPINVOKE.new_IntList__SWIG_1(other.Pointer), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public IntList(int capacity) : this(LandmarkDetectorPINVOKE.new_IntList__SWIG_2(capacity), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private int getitemcopy(int index)
        {
            int ret = LandmarkDetectorPINVOKE.IntList_getitemcopy(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private int getitem(int index)
        {
            int ret = LandmarkDetectorPINVOKE.IntList_getitem(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, int val)
        {
            LandmarkDetectorPINVOKE.IntList_setitem(swigCPtr, index, val);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(IntList values)
        {
            LandmarkDetectorPINVOKE.IntList_AddRange(swigCPtr, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public IntList GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.IntList_GetRange(swigCPtr, index, count);
            IntList ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntList(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, int x)
        {
            LandmarkDetectorPINVOKE.IntList_Insert(swigCPtr, index, x);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, IntList values)
        {
            LandmarkDetectorPINVOKE.IntList_InsertRange(swigCPtr, index, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            LandmarkDetectorPINVOKE.IntList_RemoveAt(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            LandmarkDetectorPINVOKE.IntList_RemoveRange(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static IntList Repeat(int value, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.IntList_Repeat(value, count);
            IntList ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntList(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            LandmarkDetectorPINVOKE.IntList_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            LandmarkDetectorPINVOKE.IntList_Reverse__SWIG_1(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, IntList values)
        {
            LandmarkDetectorPINVOKE.IntList_SetRange(swigCPtr, index, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool Contains(int value)
        {
            bool ret = LandmarkDetectorPINVOKE.IntList_Contains(swigCPtr, value);
            return ret;
        }

        public int IndexOf(int value)
        {
            int ret = LandmarkDetectorPINVOKE.IntList_IndexOf(swigCPtr, value);
            return ret;
        }

        public int LastIndexOf(int value)
        {
            int ret = LandmarkDetectorPINVOKE.IntList_LastIndexOf(swigCPtr, value);
            return ret;
        }

        public bool Remove(int value)
        {
            bool ret = LandmarkDetectorPINVOKE.IntList_Remove(swigCPtr, value);
            return ret;
        }

    }

}
