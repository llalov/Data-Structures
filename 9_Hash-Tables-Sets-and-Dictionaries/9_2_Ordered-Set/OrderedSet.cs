using System;

namespace _9_2_Ordered_Set
{
    public class OrderedSet<T> : RedBlackTree<T> where T : IComparable
    {
        public void Add(T element)
        {
            this.Insert(element);
        }
        public void Remove(T element)
        {
            this.Delete(element);
        }

        //TODO: UnionWith(set)
        //TODO: IntersectWiht(set)
        //TODO: ExceptWith(set)
        //TODO: SymmetricExceptWith(set)
    }
}
