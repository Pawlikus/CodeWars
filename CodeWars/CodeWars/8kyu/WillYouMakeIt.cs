using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    class WillYouMakeIt
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return distanceToPump <= mpg * fuelLeft;
        }
    }
}
