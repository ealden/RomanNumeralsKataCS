using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralConverter
    {
        public int Convert(String input)
        {
            var total = 0;

            foreach (var romanNumeral in input.ToCharArray())
            {
                total += RomanNumeralToChar(romanNumeral);
            }

            return total;
        }

        private int RomanNumeralToChar(char romanNumeral)
        {
            switch (romanNumeral)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                default: throw new UnsupportedRomanNumeralException();
            }
        }
    }

    public class UnsupportedRomanNumeralException : Exception { }
}
