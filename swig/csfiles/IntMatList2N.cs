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

    public class IntMatList2N : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IEnumerable<IntMatList>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal IntMatList2N(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntMatList2N obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~IntMatList2N()
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
                        LandmarkDetectorPINVOKE.delete_IntMatList2N(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public IntMatList2N(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (IntMatList element in c)
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

        public IntMatList this[int index]
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

        public void CopyTo(IntMatList[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(IntMatList[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, IntMatList[] array, int arrayIndex, int count)
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

        global::System.Collections.Generic.IEnumerator<IntMatList> global::System.Collections.Generic.IEnumerable<IntMatList>.GetEnumerator()
        {
            return new IntMatList2NEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new IntMatList2NEnumerator(this);
        }

        public IntMatList2NEnumerator GetEnumerator()
        {
            return new IntMatList2NEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class IntMatList2NEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<IntMatList>
        {
            private IntMatList2N collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public IntMatList2NEnumerator(IntMatList2N collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public IntMatList Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (IntMatList)currentObject;
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
            LandmarkDetectorPINVOKE.IntMatList2N_Clear(swigCPtr);
        }

        public void Add(IntMatList x)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_Add(swigCPtr, x.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = LandmarkDetectorPINVOKE.IntMatList2N_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = LandmarkDetectorPINVOKE.IntMatList2N_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_reserve(swigCPtr, n);
        }

        public IntMatList2N() : this(LandmarkDetectorPINVOKE.new_IntMatList2N__SWIG_0(), true)
        {
        }

        public IntMatList2N(IntMatList2N other) : this(LandmarkDetectorPINVOKE.new_IntMatList2N__SWIG_1(other.Pointer), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public IntMatList2N(int capacity) : this(LandmarkDetectorPINVOKE.new_IntMatList2N__SWIG_2(capacity), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private IntMatList getitemcopy(int index)
        {
            IntMatList ret = new IntMatList(LandmarkDetectorPINVOKE.IntMatList2N_getitemcopy(swigCPtr, index), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private IntMatList getitem(int index)
        {
            IntMatList ret = new IntMatList(LandmarkDetectorPINVOKE.IntMatList2N_getitem(swigCPtr, index), false);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, IntMatList val)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_setitem(swigCPtr, index, val.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(IntMatList2N values)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_AddRange(swigCPtr, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public IntMatList2N GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.IntMatList2N_GetRange(swigCPtr, index, count);
            IntMatList2N ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntMatList2N(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, IntMatList x)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_Insert(swigCPtr, index, x.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, IntMatList2N values)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_InsertRange(swigCPtr, index, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_RemoveAt(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_RemoveRange(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static IntMatList2N Repeat(IntMatList value, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.IntMatList2N_Repeat(value.Pointer, count);
            IntMatList2N ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntMatList2N(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            LandmarkDetectorPINVOKE.IntMatList2N_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_Reverse__SWIG_1(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, IntMatList2N values)
        {
            LandmarkDetectorPINVOKE.IntMatList2N_SetRange(swigCPtr, index, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
