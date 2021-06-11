using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class SumOfPositiveTest
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int SumOfPositiveTest_ShouldSucceed(int[] arr)
        {
            return SumOfPositive.PositiveSum(arr);
        }
    }
}