using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class ReversedSequanceTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ReversedSequence.ReverseSeq(5), Is.EqualTo(new[] {5, 4, 3, 2, 1}));
        }
    }
}