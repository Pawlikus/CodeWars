namespace CodeWars.CodeWars._8kyu
{
    internal class WillYouMakeIt
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return distanceToPump <= mpg * fuelLeft;
        }
    }
}