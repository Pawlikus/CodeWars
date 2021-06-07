﻿namespace CodeWars.CodeWars._8kyu
{
    internal class CalculateBmi
    {
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (height * height);
            if (bmi <= 18.5) return "Underweight";
            if (bmi <= 25.0) return "Normal";
            if (bmi <= 30.00) return "Overweight";
            return "Obese";
        }
    }
}