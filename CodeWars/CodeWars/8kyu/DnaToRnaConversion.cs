using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.CodeWars._8kyu
{
    public class DnaToRnaConversion
    {
        public static string dnaToRna(string dna)
        {
            return dna.Replace("T", "U").ToString();
        }
    }
}
