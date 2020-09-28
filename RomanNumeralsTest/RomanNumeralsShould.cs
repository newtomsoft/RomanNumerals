using RomanNumeralsCore;
using System;
using Xunit;

namespace RomanNumeralsTest
{
    public class RomanNumeralsShould
    {
        [Fact]
        public void When0001ReturnI()
        {
            Assert.Equal("I", RomanNumerals.ToRomanNumerals(1));
        }

        [Fact]
        public void When0002ReturnII()
        {
            Assert.Equal("II", RomanNumerals.ToRomanNumerals(2));
        }

        [Fact]
        public void When0003ReturnIII()
        {
            Assert.Equal("III", RomanNumerals.ToRomanNumerals(3));
        }

        [Fact]
        public void When0004ReturnIV()
        {
            Assert.Equal("IV", RomanNumerals.ToRomanNumerals(4));
        }

        [Fact]
        public void When0005ReturnV()
        {
            Assert.Equal("V", RomanNumerals.ToRomanNumerals(5));
        }

        [Fact]
        public void When0006ReturnVI()
        {
            Assert.Equal("VI", RomanNumerals.ToRomanNumerals(6));
        }

        [Fact]
        public void When0007ReturnVII()
        {
            Assert.Equal("VII", RomanNumerals.ToRomanNumerals(7));
        }

        [Fact]
        public void When0008ReturnVIII()
        {
            Assert.Equal("VIII", RomanNumerals.ToRomanNumerals(8));
        }

        [Fact]
        public void When0009ReturnIX()
        {
            Assert.Equal("IX", RomanNumerals.ToRomanNumerals(9));
        }

        [Fact]
        public void When0010ReturnX()
        {
            Assert.Equal("X", RomanNumerals.ToRomanNumerals(10));
        }

        [Fact]
        public void When0011ReturnXI()
        {
            Assert.Equal("XI", RomanNumerals.ToRomanNumerals(11));
        }

        [Fact]
        public void When0012ReturnXII()
        {
            Assert.Equal("XII", RomanNumerals.ToRomanNumerals(12));
        }

        [Fact]
        public void When0014ReturnXIV()
        {
            Assert.Equal("XIV", RomanNumerals.ToRomanNumerals(14));
        }

        [Fact]
        public void When0019ReturnXIX()
        {
            Assert.Equal("XIX", RomanNumerals.ToRomanNumerals(19));
        }

        [Fact]
        public void When0040ReturnXL()
        {
            Assert.Equal("XL", RomanNumerals.ToRomanNumerals(40));
        }

        [Fact]
        public void When0049ReturnXLIX()
        {
            Assert.Equal("XLIX", RomanNumerals.ToRomanNumerals(49));
        }

        [Fact]
        public void When0050ReturnL()
        {
            Assert.Equal("L", RomanNumerals.ToRomanNumerals(50));
        }

        [Fact]
        public void When0052ReturnLII()
        {
            Assert.Equal("LII", RomanNumerals.ToRomanNumerals(52));
        }

        [Fact]
        public void When0060ReturnLX()
        {
            Assert.Equal("LX", RomanNumerals.ToRomanNumerals(60));
        }

        [Fact]
        public void When0082ReturnLXXXII()
        {
            Assert.Equal("LXXXII", RomanNumerals.ToRomanNumerals(82));
        }

        [Fact]
        public void When0089ReturnLXXXIX()
        {
            Assert.Equal("LXXXIX", RomanNumerals.ToRomanNumerals(89));
        }

        [Fact]
        public void When0090ReturnXC()
        {
            Assert.Equal("XC", RomanNumerals.ToRomanNumerals(90));
        }

        [Fact]
        public void When0094ReturnXCIV()
        {
            Assert.Equal("XCIV", RomanNumerals.ToRomanNumerals(94));
        }

        [Fact]
        public void When0100ReturnC()
        {
            Assert.Equal("C", RomanNumerals.ToRomanNumerals(100));
        }

        [Fact]
        public void When0123ReturnCXXIII()
        {
            Assert.Equal("CXXIII", RomanNumerals.ToRomanNumerals(123));
        }

        [Fact]
        public void When0200ReturnCC()
        {
            Assert.Equal("CC", RomanNumerals.ToRomanNumerals(200));
        }

        [Fact]
        public void When0400ReturnCD()
        {
            Assert.Equal("CD", RomanNumerals.ToRomanNumerals(400));
        }

        [Fact]
        public void When0500ReturnD()
        {
            Assert.Equal("D", RomanNumerals.ToRomanNumerals(500));
        }

        [Fact]
        public void When0600ReturnDC()
        {
            Assert.Equal("DC", RomanNumerals.ToRomanNumerals(600));
        }

        [Fact]
        public void When0700ReturnDC()
        {
            Assert.Equal("DCC", RomanNumerals.ToRomanNumerals(700));
        }

        [Fact]
        public void When0800ReturnDC()
        {
            Assert.Equal("DCCC", RomanNumerals.ToRomanNumerals(800));
        }

        [Fact]
        public void When0900ReturnCM()
        {
            Assert.Equal("CM", RomanNumerals.ToRomanNumerals(900));
        }

        [Fact]
        public void When0997ReturnCMXCVII()
        {
            Assert.Equal("CMXCVII", RomanNumerals.ToRomanNumerals(997));
        }

        [Fact]
        public void When1000ReturnM()
        {
            Assert.Equal("M", RomanNumerals.ToRomanNumerals(1000));
        }

        [Fact]
        public void When1234ReturnMCCXXXIV()
        {
            Assert.Equal("MCCXXXIV", RomanNumerals.ToRomanNumerals(1234));
        }

        [Fact]
        public void When2234ReturnMCCXXXIV()
        {
            Assert.Equal("MMCCXXXIV", RomanNumerals.ToRomanNumerals(2234));
        }

        [Fact]
        public void When3999ReturnMMMCMXCIX()
        {
            Assert.Equal("MMMCMXCIX", RomanNumerals.ToRomanNumerals(3999));
        }

        [Fact]
        public void When4000ReturnException()
        {
            Assert.Throws<OverflowException>(() => RomanNumerals.ToRomanNumerals(4000));
        }
    }
}
