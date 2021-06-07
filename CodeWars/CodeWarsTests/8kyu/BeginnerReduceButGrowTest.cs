using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class BeginnerReduceButGrowTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(6, BeginnerReduceButGrow.Grow(new[] {1, 2, 3}));
            Assert.AreEqual(16, BeginnerReduceButGrow.Grow(new[] {4, 1, 1, 1, 4}));
            Assert.AreEqual(64, BeginnerReduceButGrow.Grow(new[] {2, 2, 2, 2, 2, 2}));
        }
    }
}