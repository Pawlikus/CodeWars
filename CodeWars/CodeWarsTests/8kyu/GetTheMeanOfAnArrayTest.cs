using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class GetTheMeanOfAnArrayTest
    {
        [Test]
        [TestCase(new[] {2, 2, 2, 2}, ExpectedResult = 2)]
        [TestCase(new[] {5, 10}, ExpectedResult = 7)]
        public static int FixedTest(int[] marks)
        {
            return GetTheMeanOfAnArray.GetAverage(marks);
        }
    }
}