using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class GrasshopperPersonalizedMessageTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Hello boss", GrasshopperPersonalizedMessage.Greet("Daniel", "Daniel"));
            Assert.AreEqual("Hello guest", GrasshopperPersonalizedMessage.Greet("Greg", "Daniel"));
        }
    }
}