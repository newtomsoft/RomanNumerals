using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsCore
{
    public static class RomanNumeralsExtensions
    {
        public static string ToRomanNumerals(this int number)
        {
            return RomanNumerals.Convert(number);
        }
    }
}
