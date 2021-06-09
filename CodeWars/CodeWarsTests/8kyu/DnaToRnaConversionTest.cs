using System;
using System.Collections.Generic;
using System.Text;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    class DnaToRnaConversionTest
    {
        [Test]
        public void test()
        {
            Assert.AreEqual("UUUU", DnaToRnaConversion.dnaToRna("TTTT"));
        }
    }
}
