﻿using System;

namespace _8_1_Kd_Tree
{
    public class KdTree
    {
        private Node root;
        private const int k = 2;

        public class Node
        {
            public Node(Point2D point)
            {
                this.Point = point;
            }

            public Point2D Point { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        public Node Root
        {
            get
            {
                return this.root;
            }
        }

        public bool Contains(Point2D point)
        {
            throw new NotImplementedException();
        }

        public void Insert(Point2D point)
        {
            this.root = this.Insert(this.root, point, 0);
        }

        private Node Insert(Node node, Point2D point, int depth)
        {
            if (node == null)
            {
                return new Node(point);
            }
            if (this.Compare(point, node.Point, depth) == 1)
            {
                node.Right = Insert(node.Right, point, depth + 1);
            }
            else
            {
                node.Left = Insert(node.Left, point, depth + 1);
            }
            return node;
        }

        public void EachInOrder(Action<Point2D> action)
        {
            this.EachInOrder(this.root, action);
        }

        private void EachInOrder(Node node, Action<Point2D> action)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(node.Left, action);
            action(node.Point);
            this.EachInOrder(node.Right, action);
        }

        private int Compare(Point2D a, Point2D b, int depth)
        {
            int cmp = 0;

            if(depth % k == 0)
            {
                cmp = a.X.CompareTo(b.X);
                if (cmp == 0)
                {
                    cmp = a.Y.CompareTo(b.Y);
                }
            }
            else
            {
                cmp = a.Y.CompareTo(b.Y);
                if (cmp == 0)
                {
                    cmp = a.X.CompareTo(b.X);
                }
            }
            return cmp;
        }
    }
}
