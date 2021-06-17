using System.Linq;

namespace CodeWars.CodeWars._7kyu
{
    internal class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
    }
}