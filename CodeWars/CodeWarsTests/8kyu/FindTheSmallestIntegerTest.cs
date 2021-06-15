using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class FindTheSmallestIntegerTest
    {
        [Test]
        [TestCase(new[] {78, 56, 232, 12, 11, 43}, ExpectedResult = 11)]
        [TestCase(new[] {78, 56, -2, 12, 8, -33}, ExpectedResult = -33)]
        public static int FindTheSmallestIntegerTest_ShouldSucceed(int[] args)
        {
            return FindTheSmallestInteger.FindSmallestInt(args);
        }
    }
}