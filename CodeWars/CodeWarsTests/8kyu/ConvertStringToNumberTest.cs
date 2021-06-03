using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ConvertStringToNumberTest
    {
        [Test]
        public void ConvertStringToNumberTest_ShouldSucceed()
        {
            Assert.AreEqual(1234, ConvertStringToNumber.StringToNumber("1234"));
            Assert.AreEqual(605, ConvertStringToNumber.StringToNumber("605"));
            Assert.AreEqual(1405, ConvertStringToNumber.StringToNumber("1405"));
            Assert.AreEqual(-7, ConvertStringToNumber.StringToNumber("-7"));
        }
    }
}