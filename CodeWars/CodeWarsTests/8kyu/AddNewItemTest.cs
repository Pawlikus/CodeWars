using System.Collections.Generic;
using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class AddNewItemTest
    {
        [Test]
        public void FirstTest()
        {
            var listOfNumbers = new List<int> {1, 2, 2, 2, 4, 3, 4, 5, 6, 7};
            Assert.AreEqual(AddNewItem.AddExtra(listOfNumbers).Count, listOfNumbers.Count + 1);
        }
    }
}