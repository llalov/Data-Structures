using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _6_1_Exercise_First_Last_List
{
    public class FirstLastList<T> : IFirstLastList<T> where T : IComparable<T>
    {
        private List<T> itemsList = new List<T>();
        private OrderedBag<T> treeWithDuplicates = new OrderedBag<T>();

        public int Count
        {
            get
            {
                return itemsList.Count;
            }
        }

        public void Add(T element)
        {
            itemsList.Add(element);
            treeWithDuplicates.Add(element);
        }

        public void Clear()
        {
            itemsList.Clear();
            treeWithDuplicates.Clear();
        }

        public IEnumerable<T> First(int count)
        {
            if (count > itemsList.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < count; i++)
            {
                yield return itemsList[i];
            }
        }

        public IEnumerable<T> Last(int count)
        {
            if (count > itemsList.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = itemsList.Count - 1; i >= itemsList.Count - count; i--)
            {
                yield return itemsList[i];
            }
        }

        public IEnumerable<T> Max(int count)
        {
            if (count > treeWithDuplicates.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = treeWithDuplicates.Count - 1; i >= treeWithDuplicates.Count - count; i--)
            {
                yield return treeWithDuplicates[i];
            }
        }

        public IEnumerable<T> Min(int count)
        {
            if (count > treeWithDuplicates.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 0; i < count; i++)
            {
                yield return treeWithDuplicates[i];
            }
        }

        public int RemoveAll(T element)
        {
            int initialCount = itemsList.Count;

            if (itemsList.Contains(element))
            {
                itemsList.RemoveAll(x => x.Equals(element));
                treeWithDuplicates.RemoveAll(x => x.Equals(element));
                return initialCount - itemsList.Count;    
            }
            else
            {
                return 0;
            }
            
        }
    }

}
