using System.Linq;

namespace CodeWars.CodeWars._8kyu
{
    internal class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            var splitedString = str.Split(" ");
            return string.Join(" ", splitedString.Reverse());
        }
    }
}