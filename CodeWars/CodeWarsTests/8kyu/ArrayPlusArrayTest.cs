using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class ArrayPlusArrayTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(21, ArrayPlusArray.AddArrayAndArray(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }));
            Assert.AreEqual(-21, ArrayPlusArray.AddArrayAndArray(new[] { -1, -2, -3 }, new[] { -4, -5, -6 }));
            Assert.AreEqual(15, ArrayPlusArray.AddArrayAndArray(new[] { 0, 0, 0 }, new[] { 4, 5, 6 }));
            Assert.AreEqual(2100, ArrayPlusArray.AddArrayAndArray(new[] { 100, 200, 300 }, new[] { 400, 500, 600 }));
        }
    }
}