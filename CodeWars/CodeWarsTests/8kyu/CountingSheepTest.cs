using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class CountingSheepTest
    {
        [Test]
        public void CountingSheepTest_ShouldSucceed()
        {
            var sheeps = new[] {true, false, true};

            Assert.AreEqual(2, CountingSheep.CountSheeps(sheeps));
        }
    }
}