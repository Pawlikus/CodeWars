using System;

namespace CodeWars.CodeWars._8kyu
{
    internal class NthPower
    {
        public static double Index(int[] array, int n)
        {
            var length = array.Length;
            if (length - 1 < n) return -1;
            return Math.Pow(array[n], n);
        }
    }
}