using System.Collections.Generic;

namespace CodeWars.CodeWars._8kyu
{
    internal class FilteringEvenNumbersBugFixes
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            for (int i = listOfNumbers.Count - 1; i >= 0; i--)
            {
                if (listOfNumbers[i] % 2 == 0)
                {
                    listOfNumbers.RemoveAt(i);
                }
            }
            return listOfNumbers;
        }
    }
}