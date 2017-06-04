﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_0_Tree
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public IList<Tree<T>> Children { get; private set;}

        //Constructor
        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            
            foreach (var child in children)
            {
                this.Children.Add(child);
            }
        }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
            {
                child.Print(indent + 1);
            }
        }

        public void Each(Action<T> action)
        {
            action(this.Value);

            foreach(var child in this.Children)
            {
                child.Each(action);
            }
        }

        private void DFS(Tree<T> tree, List<T> result)
        {
            foreach(var child in tree.Children)
            {
                this.DFS(child, result);
            }

            result.Add(tree.Value);
        }

        public IEnumerable<T> OrderDFS()
        {
            var result = new List<T>();
            this.DFS(this, result);

            return result;
        }

        public IEnumerable<T> OrderBFS()
        {
            throw new NotImplementedException();
        }
    }
}
 