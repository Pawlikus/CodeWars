using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    class IfYouCantSleepJustCountSheep
    {
        public static string CountSheep(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += $"{i} sheep...";
            }
            return result;
        }
    }
}
