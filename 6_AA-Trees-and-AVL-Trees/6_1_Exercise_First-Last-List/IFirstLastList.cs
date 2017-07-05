using System;
using System.Collections.Generic;

namespace _6_1_Exercise_First_Last_List
{
    public interface IFirstLastList<T> where T : IComparable<T>
    {
        void Add(T element);
        int Count { get; }
        IEnumerable<T> First(int count);
        IEnumerable<T> Last(int count);
        IEnumerable<T> Min(int count);
        IEnumerable<T> Max(int count);
        void Clear();
        int RemoveAll(T element);
    }
}
