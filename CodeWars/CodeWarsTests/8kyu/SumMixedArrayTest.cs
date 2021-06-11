using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class SumMixedArrayTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(22, SumMixedArray.SumMix(new object[] { 9, 3, "7", "3" }));
            Assert.AreEqual(42, SumMixedArray.SumMix(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            Assert.AreEqual(41, SumMixedArray.SumMix(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
        }
    }
}