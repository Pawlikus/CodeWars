using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class SumWithoutHighestAndLowestNumberTest
    {
        [Test]
        public void SumPositives()
        {
            Assert.AreEqual(16, SumWithoutHighestAndLowestNumber.Sum(new[] {6, 2, 1, 8, 10}));
        }
    }
}