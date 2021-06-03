using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
   public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
           return arr.Where(x => x > 0).Sum();
        }
    }
}
