using System;
using System.Collections.Generic;

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

        private Node Insert(Node node, T value)
        {
            if (node == null)
            {
                node = new Node(value);
            }

            else if (value.CompareTo(node.Value) > 0)
            {
                node.Right = this.Insert(node.Right, value);
            }

            else if (value.CompareTo(node.Value) < 0)
            {
                node.Left = this.Insert(node.Left, value);
            }

            return node;
        }

        private void PreOrderCopy(Node node)
        {
            if (node == null)
            {
                return;
            }

            this.Insert(node.Value);
            this.PreOrderCopy(node.Left);
            this.PreOrderCopy(node.Right);
        }

        private BinarySearchTree(Node node)
        {
            this.PreOrderCopy(node);
        }

        public BinarySearchTree()
        {
        }

        public void Insert(T value)
        {
            this.root = this.Insert(this.root, value);
        }

        public bool Contains(T value)
        {
            Node current = this.FindElement(value);

            return current != null;
        }

        public void DeleteMin()
        {
            if (this.root == null) { return; }
            Node parent = null;
            Node current = this.root;
            while (current.Left != null)
            {
                parent = current;
                current = parent.Left;
            }

            if (parent == null)
            {
                this.root = current.Right;
            }
            else
            {
                parent.Left = current.Right;
            }
        }

        public BinarySearchTree<T> Search(T item)
        {
            Node newNode = this.FindElement(item);

            return new BinarySearchTree<T>(newNode);
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

   // public class Launcher
   // {
   //     public static void Main(string[] args)
    //    {

    //    }
    //}
}
