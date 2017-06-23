using System;

namespace _4_0_BinaryHeap
{
    public static class Heap<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr)
        {
            int n = arr.Length;

            for (int i = n/2; i >= 0; i--)
            {
                //TODO heapify Element at i
            }

            for (int i = n - 1; i > 0; i--)
            {
                //TODO Swap 0 with i
                //Heapify down element at 0 
            }
        }

        private static void Down(T[] arr, int current, int border)
        {
            while (current < border / 2)
            {
                //TODO: get greater child
                //TODO: if current is greater than greater child -> break
                //TODO: swap elements
                //TODO: update the index
            }
        }
    }
}
