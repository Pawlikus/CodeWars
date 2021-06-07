using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class CalculateBmiTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Normal", CalculateBmi.Bmi(80, 1.80));
        }
    }
}