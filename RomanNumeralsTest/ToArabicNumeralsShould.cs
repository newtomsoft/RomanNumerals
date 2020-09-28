using RomanNumeralsCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace RomanNumeralsTest
{
    public class ToArabicNumeralsShould
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(14, "XIV")]
        [InlineData(19, "XIX")]
        [InlineData(40, "XL")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(52, "LII")]
        [InlineData(60, "LX")]
        [InlineData(82, "LXXXII")]
        [InlineData(89, "LXXXIX")]
        [InlineData(90, "XC")]
        [InlineData(94, "XCIV")]
        [InlineData(100, "C")]
        [InlineData(123, "CXXIII")]
        [InlineData(200, "CC")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(600, "DC")]
        [InlineData(700, "DCC")]
        [InlineData(800, "DCCC")]
        [InlineData(900, "CM")]
        [InlineData(997, "CMXCVII")]
        [InlineData(1000, "M")]
        [InlineData(1234, "MCCXXXIV")]
        [InlineData(2234, "MMCCXXXIV")]
        [InlineData(3999, "MMMCMXCIX")]
        [InlineData(50, "XXL")]

        public void ReturnExpectedWhenNumber(int expected, string romanNumber)
        {
            Assert.Equal(expected, RomanNumerals.ToArabicNumerals(romanNumber));
        }

        [Fact]
        public void ReturnExceptionWhenNumberDontExist()
        {
            Assert.Throws<KeyNotFoundException>(() => RomanNumerals.ToArabicNumerals("G"));
        }
    }
}
