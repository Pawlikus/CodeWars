using CodeWars.CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._7kyu
{
    internal class VowelCountTest
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}