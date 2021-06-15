using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class GetPlanetNameByIdTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("Venus", GetPlanetNameById.GetPlanetName(2));
            Assert.AreEqual("Jupiter", GetPlanetNameById.GetPlanetName(5));
        }
    }
}