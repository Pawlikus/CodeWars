using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class GrasshopperSummationTest
    {
        [Test]
        public static void GrasshopperSummationTest_ShouldSucceed()
        {
            Assert.AreEqual(1, GrasshopperSummation.Summation(1));
            Assert.AreEqual(36, GrasshopperSummation.Summation(8));
            Assert.AreEqual(253, GrasshopperSummation.Summation(22));
            Assert.AreEqual(5050, GrasshopperSummation.Summation(100));
            Assert.AreEqual(22791, GrasshopperSummation.Summation(213));
        }
    }
}