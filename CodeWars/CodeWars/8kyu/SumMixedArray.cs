using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    class SumMixedArray
    {
        public static int SumMix(object[] x)
        {
            return x.Sum(n => int.Parse(n.ToString()));
        }
    }
}
