using CodeWars.CodeWars._8kyu;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class FilteringEvenNumbersBugFixesTest
    {
        [Test]
        public void FirstTest()
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4, 5, 6, 7 };
            List<int> expectedResult = new List<int>() { 1, 3, 5, 7 };
            StringAssert.AreEqualIgnoringCase(string.Join(",", expectedResult), string.Join(",", FilteringEvenNumbersBugFixes.FilterOddNumber(listOfNumbers)));
        }

        [Test]
        public void SecondTest()
        {
            List<int> listOfNumbers = new List<int>() { 1, 2, 2, 2, 4, 3, 4 };
            List<int> expectedResult = new List<int>() { 1, 3 };
            StringAssert.AreEqualIgnoringCase(string.Join(",", expectedResult), string.Join(",", FilteringEvenNumbersBugFixes.FilterOddNumber(listOfNumbers)));
        }
    }
}