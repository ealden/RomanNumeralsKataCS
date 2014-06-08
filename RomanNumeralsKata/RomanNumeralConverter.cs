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
            if (IsRomanNumeralStringValid(input))
            {
                return ConvertValidRomanNumeralString(input);
            }
            else
            {
                throw new InvalidRomanNumeralStringException();
            }
        }

        private int ConvertValidRomanNumeralString(String input)
        {
            var total = 0;
            var lastNumber = 0;

            foreach (var romanNumeral in input.ToCharArray().Reverse())
            {
                var number = ConvertRomanNumeralToNumber(romanNumeral);

                if ((lastNumber != 0) && (lastNumber > number))
                {
                    number *= -1;
                }

                lastNumber = number;
                total += number;
            }

            return total;
        }

        private int ConvertRomanNumeralToNumber(char romanNumeral)
        {
            switch (romanNumeral)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: throw new UnsupportedRomanNumeralException();
            }
        }

        private bool IsRomanNumeralStringValid(String input)
        {
            var RepeatedTooMuch = (input.Contains("IIII") || input.Contains("XXXX") || input.Contains("CCCC") || input.Contains("MMMM"));
            var InvalidRepeat = (input.Contains("VV") || input.Contains("LL") || input.Contains("DD"));

            var InvalidISubtraction = (input.Contains("IL") || input.Contains("IC") || input.Contains("ID") || input.Contains("IM"));
            var InvalidXSubtraction = (input.Contains("XD") || input.Contains("XM"));

            return !(RepeatedTooMuch || InvalidRepeat || InvalidISubtraction || InvalidXSubtraction);
        }
    }

    public class UnsupportedRomanNumeralException : Exception { }
    public class InvalidRomanNumeralStringException : Exception { }
}
