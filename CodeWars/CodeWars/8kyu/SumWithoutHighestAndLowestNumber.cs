using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class SumWithoutHighestAndLowestNumber
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length < 3) return 0;

            return numbers.Sum() - numbers.Min() - numbers.Max();
        }
    }
}