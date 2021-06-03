using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class CenturyFromYearTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(18, CenturyFromYear.GetСenturyFromYear(1705));
            Assert.AreEqual(19, CenturyFromYear.GetСenturyFromYear(1900));
            Assert.AreEqual(17, CenturyFromYear.GetСenturyFromYear(1601));
            Assert.AreEqual(20, CenturyFromYear.GetСenturyFromYear(2000));
        }
    }
}