using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class TheWideMouthedFrogTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("wide", TheWideMouthedFrog.MouthSize("toucan"));
            Assert.AreEqual("wide", TheWideMouthedFrog.MouthSize("ant bear"));
            Assert.AreEqual("small", TheWideMouthedFrog.MouthSize("alligator"));
        }
    }
}