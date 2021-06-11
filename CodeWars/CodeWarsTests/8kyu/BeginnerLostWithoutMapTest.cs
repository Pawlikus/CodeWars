using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class BeginnerLostWithoutMapTest
    {
        [Test]
        public void BeginnerLostWithoutMapTest_ShouldSucceed()
        {
            Assert.AreEqual(new[] { 2, 4, 6 }, BeginnerLostWithoutMap.Maps(new[] { 1, 2, 3 }));
            Assert.AreEqual(new[] { 8, 2, 2, 2, 8 }, BeginnerLostWithoutMap.Maps(new[] { 4, 1, 1, 1, 4 }));
            Assert.AreEqual(new[] { 4, 4, 4, 4, 4, 4 }, BeginnerLostWithoutMap.Maps(new[] { 2, 2, 2, 2, 2, 2 }));
        }
    }
}