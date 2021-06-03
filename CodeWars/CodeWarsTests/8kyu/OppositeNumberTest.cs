using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class OppositeNumberTest
    {
        [Test]
        public void OppositeNumberTest_ShouldSucceed()
        {
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
        }
    }
}
