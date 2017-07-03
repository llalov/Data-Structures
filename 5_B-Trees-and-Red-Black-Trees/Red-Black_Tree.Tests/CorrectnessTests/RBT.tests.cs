using _5_0_Red_Black_Tree;
using NUnit.Framework;
using System.Collections.Generic;

namespace Red_Black_Tree.Tests.CorrectnessTests
{

    [TestFixture]
    class InsertFirst
    {
        [Test]
        public void Insert_SingleElement_ShouldIncreaseCount()
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();
            rbt.Insert(5);

            Assert.AreEqual(1, rbt.Count());
        }
    }

    [TestFixture]
    public class InsertSecond
    {
        [Test]
        public void Insert_MultipleElements_ShouldBeInsertedCorrectly()
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();
            rbt.Insert(5);
            rbt.Insert(12);
            rbt.Insert(18);
            rbt.Insert(37);
            rbt.Insert(48);
            rbt.Insert(60);
            rbt.Insert(80);

            List<int> nodes = new List<int>();
            rbt.EachInOrder(nodes.Add);

            // Assert
            int[] expectedNodes = new int[] { 5, 12, 18, 37, 48, 60, 80 };

            CollectionAssert.AreEqual(expectedNodes, nodes);
        }
    }

    [TestFixture]
    class InsertThird
    {
        [Test]
        public void Insert_MultipleElements_ShouldBeBalanced()
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();
            rbt.Insert(5);
            rbt.Insert(12);
            rbt.Insert(18);
            rbt.Insert(37);
            rbt.Insert(48);
            rbt.Insert(60);
            rbt.Insert(80);

            Assert.AreEqual(3, rbt.Search(12).Count());
            Assert.AreEqual(3, rbt.Search(60).Count());
        }
    }

    [TestFixture]
    class InsertFourth
    {
        [Test]
        [Timeout(600)]
        public void Insert_MultipleElements_ShouldBeFast()
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();

            for (int i = 0; i < 100000; i++)
            {
                rbt.Insert(i);
            }
        }
    }

    [TestFixture]
    public class FifthTest
    {
        [Test]
        [Timeout(700)]
        public void Insert_MultipleElements_ShouldHaveQuickFind()
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();

            for (int i = 0; i < 100000; i++)
            {
                rbt.Insert(i);
            }

            Assert.AreEqual(true, rbt.Contains(99999));
        }
    }
}
