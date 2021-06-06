using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class CountTheMonkeysTest
    {
        public static object[] FixedTests =
        {
            new object[] {CountTheMonkeys.MonkeyCount(5), new[] {1, 2, 3, 4, 5}},
            new object[] {CountTheMonkeys.MonkeyCount(3), new[] {1, 2, 3}},
            new object[] {CountTheMonkeys.MonkeyCount(9), new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}},
            new object[] {CountTheMonkeys.MonkeyCount(10), new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}},
            new object[]
            {
                CountTheMonkeys.MonkeyCount(20),
                new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
            }
        };

        [Test]
        [TestCaseSource("FixedTests")]
        public void FixedTest(int[] r, int[] e)
        {
            Apesert.AreEqual(e, r);
        }
    }

    public static class Apesert
    {
        public static void AreEqual(int[] a, int[] b)
        {
            Assert.AreEqual("[" + string.Join(", ", a) + "]",
                "[" + string.Join(", ", b) + "]",
                "Array did not match expected.");
        }
    }
}