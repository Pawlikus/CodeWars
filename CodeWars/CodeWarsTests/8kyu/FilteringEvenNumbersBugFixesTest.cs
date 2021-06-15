using System.Collections.Generic;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class FilteringEvenNumbersBugFixesTest
    {
        [Test]
        public void FirstTest()
        {
            var listOfNumbers = new List<int> {1, 2, 2, 2, 4, 3, 4, 5, 6, 7};
            var expectedResult = new List<int> {1, 3, 5, 7};
            StringAssert.AreEqualIgnoringCase(string.Join(",", expectedResult),
                string.Join(",", FilteringEvenNumbersBugFixes.FilterOddNumber(listOfNumbers)));
        }

        [Test]
        public void SecondTest()
        {
            var listOfNumbers = new List<int> {1, 2, 2, 2, 4, 3, 4};
            var expectedResult = new List<int> {1, 3};
            StringAssert.AreEqualIgnoringCase(string.Join(",", expectedResult),
                string.Join(",", FilteringEvenNumbersBugFixes.FilterOddNumber(listOfNumbers)));
        }
    }
}