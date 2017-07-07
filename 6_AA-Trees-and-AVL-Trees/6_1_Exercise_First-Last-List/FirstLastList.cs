using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _6_1_Exercise_First_Last_List
{
    public class FirstLastList<T> : IFirstLastList<T> where T : IComparable<T>
    {
        private List<T> itemsList = new List<T>();
        private OrderedBag<T> treeWithDuplicates = new OrderedBag<T>();
        private OrderedBag<T> reversedTreeWithDuplicates = new OrderedBag<T>((x, y) => - x.CompareTo(y));

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
            reversedTreeWithDuplicates.Add(element);
        }

        public void Clear()
        {
            itemsList.Clear();
            treeWithDuplicates.Clear();
            reversedTreeWithDuplicates.Clear();
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
            if (count > reversedTreeWithDuplicates.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            foreach (var item in reversedTreeWithDuplicates)
            {
                if (count <= 0)
                {
                    break;
                }
                yield return item;
                count--;
            }
        }

        public IEnumerable<T> Min(int count)
        {
            if (count > treeWithDuplicates.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            foreach (var item in treeWithDuplicates)
            {
                if (count <= 0)
                {
                    break;
                }
                yield return item;
                count--;
            }
        }

        public int RemoveAll(T element)
        {
            foreach (var item in treeWithDuplicates.Range(element, true, element, true))
            {
                itemsList.Remove(item);
            }

            var count = treeWithDuplicates.RemoveAllCopies(element);
            reversedTreeWithDuplicates.RemoveAllCopies(element);
            return count;
        }
    }

}
