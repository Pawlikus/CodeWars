using System;
using System.Collections.Generic;
using System.Text;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    class MakeUpperCaseTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("HELLO", MakeUpperCase.MakeStringUpperCase("hello"));
        }
    }
}
