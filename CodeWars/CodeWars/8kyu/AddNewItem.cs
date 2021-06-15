using System.Collections.Generic;

namespace CodeWars.CodeWars._8kyu
{
    internal class AddNewItem
    {
        public static List<int> AddExtra(List<int> listOfNumbers)
        {
            var finalList = listOfNumbers.ConvertAll(x => x);
            finalList.Add(3);
            return finalList;
        }
    }
}