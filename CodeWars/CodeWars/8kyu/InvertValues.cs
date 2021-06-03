using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    public class InvertValues
    {
        public static int[] GetInvertedValues(int[] input)
        {
            return input.Select(i => -i).ToArray();
        }
    }
}