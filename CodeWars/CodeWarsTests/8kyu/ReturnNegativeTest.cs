using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ReturnNegativeTest
    {
        [Test]
        public void ReturnNegativeTest_ShouldSucceed()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }
    }
}