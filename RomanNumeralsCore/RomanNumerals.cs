using System;
using System.Collections.Generic;

namespace RomanNumeralsCore
{
    public class RomanNumerals
    {
        static public string ToRomanNumerals(int number)
             => Parse.Number(number)
                .And<ConvertThousands>()
                .And<ConvertHundreds>()
                .And<ConvertTens>()
                .And<ConvertUnits>()
                .GetString();

        static public int ToArabicNumerals(string romanNumber)
        {
            int result = 0;
            var romanNumeralToArabicNumber = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

            for (int i = 0; i < romanNumber.Length - 1; i++)
            {
                if (!romanNumeralToArabicNumber.ContainsKey(romanNumber[i]))
                    throw new KeyNotFoundException($"Roman numeral {romanNumber[i]} don't exist");
                if (!romanNumeralToArabicNumber.ContainsKey(romanNumber[i+1]))
                    throw new KeyNotFoundException($"Roman numeral {romanNumber[i+1]} don't exist");

                int currentNumber = romanNumeralToArabicNumber[romanNumber[i]];
                int nextNumber = romanNumeralToArabicNumber[romanNumber[i + 1]];

                if (currentNumber >= nextNumber)
                    result += currentNumber;
                else
                    result -= currentNumber;
            }
            result += romanNumeralToArabicNumber[romanNumber[^1]];
            return result;
        }
    }
}
