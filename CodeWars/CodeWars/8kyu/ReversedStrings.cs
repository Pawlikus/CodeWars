using System;

namespace CodeWars.CodeWars._8kyu
{
    public class ReversedStrings
    {
        public static string ReverseString(string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}