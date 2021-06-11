using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class SwitchCaseBugFixing6Test
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual(2, SwitchCaseBugFixing6.EvalObject(1, 1, '+'));
            Assert.AreEqual(0, SwitchCaseBugFixing6.EvalObject(1, 1, '-'));
            Assert.AreEqual(1, SwitchCaseBugFixing6.EvalObject(1, 1, '/'));
            Assert.AreEqual(1, SwitchCaseBugFixing6.EvalObject(1, 1, '*'));
            Assert.AreEqual(0, SwitchCaseBugFixing6.EvalObject(1, 1, '%'));
            Assert.AreEqual(1, SwitchCaseBugFixing6.EvalObject(1, 1, '^'));
        }
    }
}