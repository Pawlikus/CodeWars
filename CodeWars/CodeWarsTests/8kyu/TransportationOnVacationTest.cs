using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class TransportationOnVacationTest
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            testing(TransportationOnVacation.RentalCarCost(1), 40);
            testing(TransportationOnVacation.RentalCarCost(3), 100);
            testing(TransportationOnVacation.RentalCarCost(7), 230);
        }
    }
}