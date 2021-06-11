using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class InvertValuesTest
    {
        [Test]
        public void InvertValuesTest_ShouldSucceed()
        {
            Assert.AreEqual(new[] { -1, -2, -3, -4, -5 }, InvertValues.GetInvertedValues(new[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new[] { -1, 2, -3, 4, -5 }, InvertValues.GetInvertedValues(new[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, InvertValues.GetInvertedValues(new int[] { }));
            Assert.AreEqual(new[] { 0 }, InvertValues.GetInvertedValues(new[] { 0 }));
        }
    }
}