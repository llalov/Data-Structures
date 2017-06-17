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
            public int Count { get; set;}

        }

        private int Count(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return node.Count;
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

            node.Count = 1 + this.Count(node.Left) + this.Count(node.Right);
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

        private Node DeleteMin(Node node)
        {
            if (node.Left == null)
            {
                return node.Right;
            }

            node.Left = this.DeleteMin(node.Left);
            node.Count--;

            return node;
        }

        private Node DeleteMax(Node node)
        {
            if (node.Right == null)
            {
                return node.Left;
            }

            node.Right = this.DeleteMax(node.Right);
            node.Count--;

            return node;
        }

        private int Rank(T element, Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int compare = element.CompareTo(node.Value);

            if (compare > 0)
            {
                return 1 + this.Count(node.Left) + this.Rank(element, node.Right);
            }

            if (compare < 0)
            {
                return this.Rank(element, node.Left);
            }

            return this.Count(node.Left);
        }

        public int Count()
        {
            return this.Count(this.root);
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
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

        public void Insert(T value)
        {
            this.root = this.Insert(this.root, value);
        }

        public BinarySearchTree()
        {
        }

        public void DeleteMin()
        {
            if (this.root == null) { return; }
            this.root = this.DeleteMin(this.root);
        }

        public void DeleteMax()
        {
            if (this.root == null) { return; }
            this.root = this.DeleteMax(this.root);
        }

        public bool Contains(T value)
        {
            Node current = this.FindElement(value);

            return current != null;
        }

        public int Rank(T element)
        {
            return this.Rank(element, this.root);
        }

        
    }
}
