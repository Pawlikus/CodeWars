using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class RemoveFirstAndLastCharacterTest
    {
        [Test]
        public void RemoveFirstAndLastCharacterTest_ShouldSucceed()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstAndLastCharacter.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstAndLastCharacter.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstAndLastCharacter.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstAndLastCharacter.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstAndLastCharacter.Remove_char("ok"));
        }
    }
}