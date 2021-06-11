using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class CountOfPositivesSumOfNegativesTest
    {
        [Test]
        public void CountPositivesSumNegatives_BasicTest()
        {
            int[] expectedResult = { 10, -65 };

            Assert.AreEqual(expectedResult,
                CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(new[]
                    {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15}));
        }

        [Test]
        public void CountPositivesSumNegatives_InputWithZeroes()
        {
            int[] expectedResult = { 8, -50 };

            Assert.AreEqual(expectedResult,
                CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(new[]
                    {0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14}));
        }
    }
}