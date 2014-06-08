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
            switch (input)
            {
                case "I": return 1;
                case "V": return 5;
                default: return 0;
            }
        }
    }
}
