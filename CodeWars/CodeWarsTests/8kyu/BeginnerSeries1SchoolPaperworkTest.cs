using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class BeginnerSeries1SchoolPaperworkTest
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(25, BeginnerSeries1SchoolPaperwork.Paperwork(5, 5));
        }
    }
}