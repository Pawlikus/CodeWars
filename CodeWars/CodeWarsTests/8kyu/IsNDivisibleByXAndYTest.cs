using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class IsNDivisibleByXAndYTest
    {
        [Test]
        public void IsNDivisibleByXAndYTest_ShouldSuceed()
        {
            Assert.AreEqual(true, IsNDivisibleByXAndY.isDivisible(12, 4, 3));
            Assert.AreEqual(false, IsNDivisibleByXAndY.isDivisible(3, 3, 4));
            Assert.AreEqual(false, IsNDivisibleByXAndY.isDivisible(8, 3, 4));
        }
    }
}