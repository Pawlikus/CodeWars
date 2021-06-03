using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class MultiplyNumbersTest
    {
        [Test]
        public void ShouldMultipleTest_ShouldSucceed()
        {
            Assert.AreEqual(2, MultiplyNumbers.Multiply(2, 1));
            Assert.AreEqual(8, MultiplyNumbers.Multiply(2, 4));
        }
    }
}