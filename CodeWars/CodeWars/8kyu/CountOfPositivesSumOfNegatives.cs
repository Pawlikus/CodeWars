using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class CountOfPositivesSumOfNegatives
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input?.Length == 0 || input == null) return new int[0];
            var count = input.Count(n => n > 0);
            var sum = input.Where(n => n < 0).Sum();

            int[] result = { count, sum };
            return result;
        }
    }
}