using System;

namespace CodeWars.CodeWars._8kyu
{
    public class TotalAmountOfPoints
    {
        public static int TotalPoints(string[] games)
        {
            var score = 0;
            foreach (var game in games)
            {
                var matchResult = game.Split(":");
                if (Convert.ToInt32(matchResult[0]) > Convert.ToInt32(matchResult[1])) score += 3;
                if (Convert.ToInt32(matchResult[0]) == Convert.ToInt32(matchResult[1])) score += 1;
            }

            return score;
        }
    }
}