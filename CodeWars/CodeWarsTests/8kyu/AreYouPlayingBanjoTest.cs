using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests
{
    internal class AreYouPlayingBanjoTest
    {
        [Test]
        public static void Martin()
        {
            Assert.AreEqual("Martin does not play banjo", AreYouPlayingBanjo.AreYouPlayingBanjoo("Martin"));
        }

        [Test]
        public static void Rikke()
        {
            Assert.AreEqual("Rikke plays banjo", AreYouPlayingBanjo.AreYouPlayingBanjoo("Rikke"));
        }
    }
}