using CodeWars.CodeWars._8kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ConvertNumberToStringTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(67).Returns("67");
                yield return new TestCaseData(79585).Returns("79585");
                yield return new TestCaseData(1 + 2).Returns("3");
                yield return new TestCaseData(1 - 2).Returns("-1");
            }
        }

        [Test]
        [TestCaseSource("testCases")]
        public string ConvertNumberToStringTest_ShouldSucceed(int num)
        {
            return ConvertNumberToString.NumberToString(num);
        }
    }
}