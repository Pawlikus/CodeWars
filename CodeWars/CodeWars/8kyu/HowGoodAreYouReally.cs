using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class HowGoodAreYouReally
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Average() < YourPoints;
        }
    }
}