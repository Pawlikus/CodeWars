using System.Collections.Generic;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class SquareSumTest
    {
        private static IEnumerable<TestCaseData> SampleTestCases
        {
            get
            {
                yield return new TestCaseData(new[] {1, 2, 2}).Returns(9);
                yield return new TestCaseData(new[] {1, 2}).Returns(5);
                yield return new TestCaseData(new[] {5, 3, 4}).Returns(50);
            }
        }

        [Test]
        [TestCaseSource("SampleTestCases")]
        [Description("Sample Tests")]
        public int SquareSumTest_ShouldSucceed(int[] n)
        {
            return SquareSum.SquareSumArray(n);
        }
    }
}