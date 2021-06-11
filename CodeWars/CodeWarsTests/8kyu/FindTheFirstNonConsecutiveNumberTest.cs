using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class FindTheFirstNonConsecutiveNumberTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(6, FindTheFirstNonConsecutiveNumber.FirstNonConsecutive(new[] { 1, 2, 3, 4, 6, 7, 8 }));
        }
    }
}