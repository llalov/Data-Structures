using System;
using System.Collections.Generic;

namespace _3_0_Tree
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; set;}
        public IList<Tree<T>> Children { get; private set;}

        //Constructor
        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            
            foreach (var child in children)
            {
                child.Parent = this;
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
            var result = new List<T>();
            var queue = new Queue<Tree<T>>();

            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                result.Add(node.Value);
                foreach(var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;
        }   
    }
}
 