using System.Collections.Generic;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class LarioAndMuigiPipeProblemTest
    {
        [Test]
        public void FixThosePipes_t1()
        {
            Assert.AreEqual(new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9},
                LarioAndMuigiPipeProblem.PipeFix(new List<int> {1, 2, 3, 5, 6, 8, 9}));
        }

        [Test]
        public void FixThosePipes_t2()
        {
            Assert.AreEqual(new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12},
                LarioAndMuigiPipeProblem.PipeFix(new List<int> {1, 2, 3, 12}));
        }

        [Test]
        public void FixThosePipes_t3()
        {
            Assert.AreEqual(new List<int> {6, 7, 8, 9}, LarioAndMuigiPipeProblem.PipeFix(new List<int> {6, 9}));
        }
    }
}