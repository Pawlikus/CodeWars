using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            return array.Length == 0 ? 0 : array.Average();
        }
    }
}