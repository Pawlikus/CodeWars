using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class ReturningStringsTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReturningStrings.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }
}