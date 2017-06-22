using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_0_BinaryHeap
{
    public class BinaryHeap<T> where T : IComparable<T>
    {
        private List<T> heap;

        private bool IsLess(int parentIndex, int index)
        {
            T child = this.heap[index];
            T parent = this.heap[parentIndex];
            bool result = child.CompareTo(parent) > 0;

            return result;
        }

        private int Parent(int childIndex)
        {
            int parentIndex = (childIndex - 1) / 2;
            return parentIndex;
        }

        private int LeftChild(int parentIndex)
        {
            int leftChildIndex = (2 * parentIndex) + 1;
            return leftChildIndex;
        }

        private int RightChild(int parentIndex)
        {
            int rightChildIndex = (2 * parentIndex) + 2;
            return rightChildIndex;
        }

        private void Swap(int firstElement, int secondElement)
        {
            T tmp = this.heap[firstElement]; 
            this.heap[firstElement] = this.heap[secondElement];
            this.heap[secondElement] = tmp;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0 && IsLess(Parent(index), index))
            {
                this.Swap(index, Parent(index));
                int parentIndex = Parent(index);
                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index < this.heap.Count / 2)
            {
                int leftChild = this.LeftChild(index);
                int rightChild = this.RightChild(index);
                bool hasRight = this.heap.Count >= rightChild + 1;

                if (hasRight && IsLess(leftChild, rightChild))
                {
                    leftChild = leftChild + 1;
                }

                if (IsLess(leftChild, index)) break;
                this.Swap(index, leftChild);
                index = leftChild;
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
            if (this.Count <= 0)
            {
                throw new InvalidOperationException();
            }

            T item = this.heap[0];
            this.Swap(0, this.heap.Count() - 1);
            this.heap.RemoveAt(this.heap.Count() - 1);
            this.HeapifyDown(0);

            return item;
        }
    }

}
