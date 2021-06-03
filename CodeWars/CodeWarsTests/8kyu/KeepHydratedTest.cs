using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class KeepHydratedTest
    {
        [Test]
        public static void KeepHydratedTest_ShouldSucceed()
        {
            Assert.AreEqual(1, KeepHydrated.Litres(2));
            Assert.AreEqual(0, KeepHydrated.Litres(1.4));
            Assert.AreEqual(6, KeepHydrated.Litres(12.3));
            Assert.AreEqual(0, KeepHydrated.Litres(0.82));
            Assert.AreEqual(5, KeepHydrated.Litres(11.8));
            Assert.AreEqual(893, KeepHydrated.Litres(1787));
            Assert.AreEqual(0, KeepHydrated.Litres(0));
        }
    }
}