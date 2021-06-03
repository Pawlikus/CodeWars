using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class BeginnerSeries2ClockTest
    {
        [Test]
        public void BeginnerSeries2ClockTest_ShouldSucceed()
        {
            Assert.AreEqual(61000, BeginnerSeries2Clock.Past(0, 1, 1));
        }
    }
}