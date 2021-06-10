using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class CountOddNumbersBelowNTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(7, CountOddNumbersBelowN.OddCount(15));
            Assert.AreEqual(7511, CountOddNumbersBelowN.OddCount(15023));
        }
    }
}