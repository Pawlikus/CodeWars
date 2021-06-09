using System;
using System.Collections.Generic;
using System.Text;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    class FindTheFirstNonConsecutiveNumberTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(6, FindTheFirstNonConsecutiveNumber.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 }));
        }
    }
}
