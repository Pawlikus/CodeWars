using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class DnaToRnaConversionTest
    {
        [Test]
        public void test()
        {
            Assert.AreEqual("UUUU", DnaToRnaConversion.dnaToRna("TTTT"));
        }
    }
}