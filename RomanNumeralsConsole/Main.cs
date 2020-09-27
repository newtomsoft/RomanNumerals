using System;

namespace RomanNumeralsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 5, 9, 10, 25, 45, 50, 57, 100, 500, 1000, 1789, 1515, 1914, 1918, 1939, 1945, 2020, 3999 };
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} ->  {RomanNumerals.Convert(number)}");
            }
        }
    }
}
