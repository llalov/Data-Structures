﻿using _5_0_Red_Black_Tree;
using NUnit.Framework;

namespace Red_Black_Tree.Tests.TimeTests
{
    [TestFixture]
    class InsertFourth
    {
        [Test]
        [Timeout(500)]
        public void Insert_MultipleElements_ShouldBeFast()
        {
            RedBlackTree<int> rbt = new RedBlackTree<int>();

            for (int i = 0; i < 100000; i++)
            {
                rbt.Insert(i);
            }

        }
    }
}
