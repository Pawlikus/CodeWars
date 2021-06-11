using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ConvertNumberToReversedArrayOfDigitsTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, ConvertNumberToReversedArrayOfDigits.Digitize(35231));
        }
    }
}