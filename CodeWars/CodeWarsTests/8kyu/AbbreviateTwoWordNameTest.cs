using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class AbbreviateTwoWordNameTest
    {
        [Test]
        public void AbbreviateTwoWordNameTest_ShouldSucceed()
        {
            Assert.AreEqual("S.H", AbbreviateTwoWordName.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", AbbreviateTwoWordName.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", AbbreviateTwoWordName.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", AbbreviateTwoWordName.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", AbbreviateTwoWordName.AbbrevName("David Mendieta"));
        }
    }
}