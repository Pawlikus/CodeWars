using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class FakeBinaryTest
    {
        [Test]
        public void FakeBinaryTest_ShouldSucceed()
        {
            Assert.AreEqual("01011110001100111", FakeBinary.FakeBin("45385593107843568"));
            Assert.AreEqual("101000111101101", FakeBinary.FakeBin("509321967506747"));
            Assert.AreEqual("011011110000101010000011011", FakeBinary.FakeBin("366058562030849490134388085"));
        }
    }
}