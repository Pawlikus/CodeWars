using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class LeonadroDicaprioAndOscarsTest
    {
        [Test]
        [TestCase(88, ExpectedResult = "Leo finally won the oscar! Leo is happy")]
        public string LeoTest(int oscar)
        {
            return LeonadroDicaprioAndOscars.Leo(oscar);
        }
    }
}