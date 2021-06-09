using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class WillYouMakeItTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, WillYouMakeIt.ZeroFuel(50, 25, 2));
            Assert.AreEqual(false, WillYouMakeIt.ZeroFuel(100, 50, 1));
        }
    }
}