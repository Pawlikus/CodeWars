using CodeWars.CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._6kyu
{
    internal class MultiplesOf3Or5Test
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, MultiplesOf3Or5.Solution(10));
        }
    }
}