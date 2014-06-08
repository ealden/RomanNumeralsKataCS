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
            if (!IsRomanNumeralStringValid(input))
            {
                throw new InvalidRomanNumeralStringException();
            }

            return ConvertValidRomanNumeralString(input);
        }

        private int ConvertValidRomanNumeralString(String input)
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
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: throw new UnsupportedRomanNumeralException();
            }
        }

        private bool IsRomanNumeralStringValid(String input)
        {
            var lastRomanNumeral = 'Z';
            var repeatCount = 0;

            foreach (var romanNumeral in input.ToCharArray())
            {
                if (lastRomanNumeral != 'Z')
                {
                    if (lastRomanNumeral == romanNumeral)
                    {
                        repeatCount++;
                    }

                    bool romanNumeralNotRepeatable = (romanNumeral == 'V') || (romanNumeral == 'L') || (romanNumeral == 'D');
                    bool romanNumeralRepeated = repeatCount > 0;

                    if (romanNumeralNotRepeatable && romanNumeralRepeated)
                    {
                        return false;
                    }

                    if (repeatCount == 3)
                    {
                        return false;
                    }
                }

                lastRomanNumeral = romanNumeral;
            }

            return true;
        }
    }

    public class UnsupportedRomanNumeralException : Exception { }
    public class InvalidRomanNumeralStringException : Exception { }
}
