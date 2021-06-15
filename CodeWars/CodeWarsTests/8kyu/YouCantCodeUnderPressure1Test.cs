using System.Collections.Generic;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class YouCantCodeUnderPressure1Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(2).Returns(4);
                yield return new TestCaseData(4).Returns(8);
                yield return new TestCaseData(-10).Returns(-20);
                yield return new TestCaseData(0).Returns(0);
                yield return new TestCaseData(100).Returns(200);
            }
        }

        [Test]
        [TestCaseSource("testCases")]
        public int Test(int n)
        {
            return YouCantCodeUnderPressure1.DoubleInteger(n);
        }
    }
}