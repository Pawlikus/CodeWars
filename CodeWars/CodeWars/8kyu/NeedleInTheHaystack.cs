using System;

namespace CodeWars.CodeWars._8kyu
{
    public class NeedleInTheHaystack
    {
        public static string FindNeedle(object[] haystack)
        {
            return "found the needle at position " + Array.IndexOf(haystack, "needle");
        }
    }
}