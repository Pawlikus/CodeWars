using System;
using System.Collections.Generic;
using System.Text;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    class ConvertBooleanToStringTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("True", ConvertBooleanToString.boolean_to_string(true));
            Assert.AreEqual("False", ConvertBooleanToString.boolean_to_string(false));
        }
    }
}
