using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class HowGoodAreYouReallyTest
    {
        [Test]
        [TestCase(new[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public static bool FixedTest(int[] arr, int num)
        {
            return HowGoodAreYouReally.BetterThanAverage(arr, num);
        }
    }
}