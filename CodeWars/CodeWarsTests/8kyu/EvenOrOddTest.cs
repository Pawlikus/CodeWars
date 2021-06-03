using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    class EvenOrOddTest
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void EvenOrOddTest()
            {
                Assert.AreEqual("Even", EvenOdd.EvenOrOdd(2));
                Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(1));
                Assert.AreEqual("Even", EvenOdd.EvenOrOdd(0));
                Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(7));
                Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(-1));
            }
        }
    }
}
