using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    class FindTheFirstNonConsecutiveNumber
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1];
                }
            }
            return null;
        }
    }
}
