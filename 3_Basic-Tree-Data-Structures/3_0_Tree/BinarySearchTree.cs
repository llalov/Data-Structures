using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_0_Tree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node root;

        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get;  set;}

        }

        private void EachInOrder(Node node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(node.Left, action);
            action(node.Value);
            this.EachInOrder(node.Right, action);
        }

        private Node FindElement (T element)
        {
            Node currentNode = this.root;

            while (currentNode != null)
            {
                if (element.CompareTo(currentNode.Value) > 0)
                {
                    currentNode = currentNode.Right;
                }

                else if (element.CompareTo(currentNode.Value) < 0)
                {
                    currentNode = currentNode.Left;
                }

                else
                {
                    break;
                }
            }

            return currentNode;
        }

        public void Insert(T value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            Node current = this.FindElement(value);

            return current != null;
        }

        public void DeleteMin()
        {
            throw new NotImplementedException();
        }

        public BinarySearchTree<T> Search(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Range(T startRange, T endRange)
        {
            throw new NotImplementedException();
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
        }
    }

    public class Launcher
    {
        public static void Main(string[] args)
        {

        }
    }
}
