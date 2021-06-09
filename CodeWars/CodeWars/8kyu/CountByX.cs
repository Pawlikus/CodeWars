using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    class CountByX
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z ={};
            z = Enumerable.Range(1, n).Select(i => i*x).ToArray();
            return z;
        }
    }
}
