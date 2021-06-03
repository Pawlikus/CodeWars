using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ConvertBooleanValuesToStringTest
    {
        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToString.boolToWord(true));
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", ConvertBooleanValuesToString.boolToWord(false));
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", ConvertBooleanValuesToString.boolToWord(true));
        }
    }
}