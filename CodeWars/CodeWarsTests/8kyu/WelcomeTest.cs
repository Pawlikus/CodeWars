using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class WelcomeTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Welcome", Welcome.Greet("english"));
            Assert.AreEqual("Welkom", Welcome.Greet("dutch"));
            Assert.AreEqual("Welcome", Welcome.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Welcome.Greet(""));
            Assert.AreEqual("Welcome", Welcome.Greet("2"));
        }
    }
}