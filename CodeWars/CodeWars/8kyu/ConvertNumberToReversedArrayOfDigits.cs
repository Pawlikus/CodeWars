using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class ConvertNumberToReversedArrayOfDigits
    {
        public static long[] Digitize(long n)
        {
            return $"{n}".Select(c => (long) c - '0').Reverse().ToArray();
        }
    }
}