using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class SentenceSmashTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("hello", SentenceSmash.Smash(new[] {"hello"}));
            Assert.AreEqual("hello world", SentenceSmash.Smash(new[] {"hello", "world"}));
            Assert.AreEqual("hello amazing world", SentenceSmash.Smash(new[] {"hello", "amazing", "world"}));
            Assert.AreEqual("this is a really long sentence",
 SentenceSmash.Smash(new[] {"this", "is", "a", "really", "long", "sentence"}));
            Assert.AreEqual("", SentenceSmash.Smash(new[] {""}));
        }
    }
}