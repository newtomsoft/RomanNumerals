using System;

namespace RomanNumeralsCore
{
    public class RomanNumerals
    {
        static public string ToRomanNumerals(int number)
        {
            if (number == 0) return "";
            string result = "";
            if (number < 10)
            {
                if (number < 4)
                {
                    for (int i = 1; i <= number; i++)
                        result += "I";
                }
                else if (number < 5)
                {
                    result += "IV";
                }
                else if (number < 9)
                {
                    result += "V";
                    for (int i = 6; i <= number; i++)
                        result += "I";
                }
                else // ==9
                {
                    result += "IX";
                }
                return result;
            }
            if (number < 100)
            {
                int quotient = number / 10;
                if (number < 40)
                {
                    for (int i = 1; i <= quotient; i++)
                        result += "X";
                }
                else if (number < 50)
                {
                    result += "XL";
                }
                else if (number < 90)
                {
                    result += "L";
                    for (int i = 6; i <= quotient; i++)
                        result += "X";
                }
                else // = 9
                {
                    result += "XC";
                }
                return result + ToRomanNumerals(number - quotient * 10);
            }
            if (number < 1000)
            {
                int quotient = number / 100;
                if (number < 400)
                {
                    for (int i = 1; i <= quotient; i++)
                        result += "C";

                    return result + ToRomanNumerals(number - quotient * 100);
                }
                else if (number < 500)
                {
                    result += "CD";
                    return result + ToRomanNumerals(number - quotient * 100);
                }
                else if (number < 900)
                {
                    result += "D";
                    for (int i = 6; i <= quotient; i++)
                        result += "C";

                    return result + ToRomanNumerals(number - quotient * 100);
                }
                else // >= 900
                    return "CM" + ToRomanNumerals(number - quotient * 100);
            }
            if (number < 4000)
            {
                int quotient = number / 1000;
                for (int i = 0; i < quotient; i++)
                    result += "M";

                return result + ToRomanNumerals(number - quotient * 1000);
            }
            throw new OverflowException("number must be less or equal than 3999");
        }


    }
}
