using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class TheFeastOfManyBeastsTest
    {
        [TestCase("great blue heron", "garlic naan")]
        [TestCase("chickadee", "chocolate cake")]
        public void BasicTestsTrue(string beast, string dish)
        {
            Assert.IsTrue(TheFeastOfManyBeasts.Feast(beast, dish));
        }

        [TestCase("brown bear", "bear claw")]
        public void BasicTestsFalse(string beast, string dish)
        {
            Assert.IsFalse(TheFeastOfManyBeasts.Feast(beast, dish));
        }
    }
}