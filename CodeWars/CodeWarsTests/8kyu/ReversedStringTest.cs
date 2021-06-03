using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ReversedStringTest
    {
        [Test]
        public void ReversedStringTest_ShouldSucceed()
        {
            Assert.AreEqual("dlrow", ReversedStrings.ReverseString("world"));
        }
    }
}