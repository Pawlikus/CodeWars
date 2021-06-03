using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class BasicMathematicalOperationsTest
    {
        [Test]
        public void BasicMathematicalOperationsTest_ShouldSucceed()
        {
            Assert.AreEqual(BasicMathematicalOperations.basicOp('+', 4, 7), 11);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('-', 15, 18), -3);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('*', 5, 5), 25);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('/', 49, 7), 7);
        }
    }
}