using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class IfYouCantSleepJustCountSheepTest
    {
        [Test]
        [Description("Example Tests")]
        public void ExampleTests()
        {
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(1), Is.EqualTo("1 sheep..."));
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
            Assert.That(IfYouCantSleepJustCountSheep.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
        }
    }
}