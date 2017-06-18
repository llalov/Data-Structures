using System;
using System.Collections.Generic;

namespace _4_0_BinaryHeap
{
    public class BinaryHeap<T> where T : IComparable<T>
    {
        private List<T> heap;

        private bool IsLess(T parent, int index)
        {
            T child = this.heap[index];
            bool result = child.CompareTo(parent) > 0;

            return result;
        }

        private T Parent(int index)
        {
            return this.heap[index - 1];
        }

        private void Swap(int childIndex, T parent)
        {
            int parentIndex = this.heap.IndexOf(parent);
            this.heap[parentIndex] = this.heap[childIndex]; 
            this.heap[childIndex] = parent;
        
        }

        private void HeapifyUp(int index)
        {
            while (index > 0 && IsLess(Parent(index), index))
            {
                this.Swap(index, Parent(index));
                int parentIndex = this.heap.IndexOf(Parent(index));
                index = parentIndex;
            }
        }

        public BinaryHeap()
        {
            this.heap = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.heap.Count;
            }
        }

        public void Insert(T item)
        {
            this.heap.Add(item);
            this.HeapifyUp(this.heap.Count - 1);
        }

        public T Peek()
        {
            return this.heap[0];
        }

        public T Pull()
        {
            throw new NotImplementedException();
        }
    }

}
