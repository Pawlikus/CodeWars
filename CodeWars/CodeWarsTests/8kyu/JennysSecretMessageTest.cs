using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class JennysSecretMessageTest
    {
        [Test]
        public static void ShouldGreetJimNormally()
        {
            Assert.AreEqual("Hello, Jim!", JennysSecretMessage.greet("Jim"));
        }

        [Test]
        public static void ShouldGreetJaneNormally()
        {
            Assert.AreEqual("Hello, Jane!", JennysSecretMessage.greet("Jane"));
        }

        [Test]
        public static void ShouldGreetSimonNormally()
        {
            Assert.AreEqual("Hello, Simon!", JennysSecretMessage.greet("Simon"));
        }

        [Test]
        public static void ShouldGreetJohnnySpecially()
        {
            Assert.AreEqual("Hello, my love!", JennysSecretMessage.greet("Johnny"));
        }
    }
}