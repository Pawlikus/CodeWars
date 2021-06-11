using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class FindMaximumAndMinimumValuesOfAListTest
    {
        [Test]
        public void TestExamples()
        {
            Assert.AreEqual(-110, new FindMaximumAndMinimumValuesOfAList().Min(new[] { -52, 56, 30, 29, -54, 0, -110 }));
            Assert.AreEqual(0, new FindMaximumAndMinimumValuesOfAList().Min(new[] { 42, 54, 65, 87, 0 }));
            Assert.AreEqual(566, new FindMaximumAndMinimumValuesOfAList().Max(new[] { 4, 6, 2, 1, 9, 63, -134, 566 }));
            Assert.AreEqual(5, new FindMaximumAndMinimumValuesOfAList().Max(new[] { 5 }));
        }
    }
}