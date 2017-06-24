using _5_0_Red_Black_Tree;
using NUnit.Framework;

namespace Red_Black_Tree.Tests.CorrectnessTests
{
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
}
