using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    class HowGoodAreYouReally
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Average() < YourPoints;
        }
    }
}
