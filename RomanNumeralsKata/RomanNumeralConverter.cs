﻿using System;
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

                    bool romanNumeralNotRepeatable = (romanNumeral == 'V');
                    bool romanNumeralRepeated = repeatCount > 0;

                    if (romanNumeralNotRepeatable && romanNumeralRepeated)
                    {
                        throw new InvalidRomanNumeralStringException();
                    }

                    if (repeatCount == 3)
                    {
                        throw new InvalidRomanNumeralStringException();
                    }
                }

                lastRomanNumeral = romanNumeral;

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
    }

    public class UnsupportedRomanNumeralException : Exception { }
    public class InvalidRomanNumeralStringException : Exception { }
}
