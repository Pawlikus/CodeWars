using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ConvertBooleanValuesToStringTest
    {
        [Test]
        public void ConvertBooleanValuesToStringTest_ShouldSucceed()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToString.BoolToWord(true));
            Assert.AreEqual("No", ConvertBooleanValuesToString.BoolToWord(false));
            Assert.AreEqual("Yes", ConvertBooleanValuesToString.BoolToWord(true));
        }
    }
}