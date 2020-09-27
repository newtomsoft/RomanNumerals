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
            Assert.Equal("I", RomanNumerals.Convert(1));
        }

        [Fact]
        public void When0002ReturnII()
        {
            Assert.Equal("II", RomanNumerals.Convert(2));
        }

        [Fact]
        public void When0003ReturnIII()
        {
            Assert.Equal("III", RomanNumerals.Convert(3));
        }

        [Fact]
        public void When0004ReturnIV()
        {
            Assert.Equal("IV", RomanNumerals.Convert(4));
        }

        [Fact]
        public void When0005ReturnV()
        {
            Assert.Equal("V", RomanNumerals.Convert(5));
        }

        [Fact]
        public void When0006ReturnVI()
        {
            Assert.Equal("VI", RomanNumerals.Convert(6));
        }

        [Fact]
        public void When0007ReturnVII()
        {
            Assert.Equal("VII", RomanNumerals.Convert(7));
        }

        [Fact]
        public void When0008ReturnVIII()
        {
            Assert.Equal("VIII", RomanNumerals.Convert(8));
        }

        [Fact]
        public void When0009ReturnIX()
        {
            Assert.Equal("IX", RomanNumerals.Convert(9));
        }

        [Fact]
        public void When0010ReturnX()
        {
            Assert.Equal("X", RomanNumerals.Convert(10));
        }

        [Fact]
        public void When0011ReturnXI()
        {
            Assert.Equal("XI", RomanNumerals.Convert(11));
        }

        [Fact]
        public void When0012ReturnXII()
        {
            Assert.Equal("XII", RomanNumerals.Convert(12));
        }

        [Fact]
        public void When0014ReturnXIV()
        {
            Assert.Equal("XIV", RomanNumerals.Convert(14));
        }

        [Fact]
        public void When0019ReturnXIX()
        {
            Assert.Equal("XIX", RomanNumerals.Convert(19));
        }

        [Fact]
        public void When0040ReturnXL()
        {
            Assert.Equal("XL", RomanNumerals.Convert(40));
        }

        [Fact]
        public void When0049ReturnXLIX()
        {
            Assert.Equal("XLIX", RomanNumerals.Convert(49));
        }

        [Fact]
        public void When0050ReturnL()
        {
            Assert.Equal("L", RomanNumerals.Convert(50));
        }

        [Fact]
        public void When0052ReturnLII()
        {
            Assert.Equal("LII", RomanNumerals.Convert(52));
        }

        [Fact]
        public void When0060ReturnLX()
        {
            Assert.Equal("LX", RomanNumerals.Convert(60));
        }

        [Fact]
        public void When0082ReturnLXXXII()
        {
            Assert.Equal("LXXXII", RomanNumerals.Convert(82));
        }

        [Fact]
        public void When0089ReturnLXXXIX()
        {
            Assert.Equal("LXXXIX", RomanNumerals.Convert(89));
        }

        [Fact]
        public void When0090ReturnXC()
        {
            Assert.Equal("XC", RomanNumerals.Convert(90));
        }

        [Fact]
        public void When0094ReturnXCIV()
        {
            Assert.Equal("XCIV", RomanNumerals.Convert(94));
        }

        [Fact]
        public void When0100ReturnC()
        {
            Assert.Equal("C", RomanNumerals.Convert(100));
        }

        [Fact]
        public void When0123ReturnCXXIII()
        {
            Assert.Equal("CXXIII", RomanNumerals.Convert(123));
        }

        [Fact]
        public void When0200ReturnCC()
        {
            Assert.Equal("CC", RomanNumerals.Convert(200));
        }

        [Fact]
        public void When0400ReturnCD()
        {
            Assert.Equal("CD", RomanNumerals.Convert(400));
        }

        [Fact]
        public void When0500ReturnD()
        {
            Assert.Equal("D", RomanNumerals.Convert(500));
        }

        [Fact]
        public void When0600ReturnDC()
        {
            Assert.Equal("DC", RomanNumerals.Convert(600));
        }

        [Fact]
        public void When0700ReturnDC()
        {
            Assert.Equal("DCC", RomanNumerals.Convert(700));
        }

        [Fact]
        public void When0800ReturnDC()
        {
            Assert.Equal("DCCC", RomanNumerals.Convert(800));
        }

        [Fact]
        public void When0900ReturnCM()
        {
            Assert.Equal("CM", RomanNumerals.Convert(900));
        }

        [Fact]
        public void When0997ReturnCMXCVII()
        {
            Assert.Equal("CMXCVII", RomanNumerals.Convert(997));
        }

        [Fact]
        public void When1000ReturnM()
        {
            Assert.Equal("M", RomanNumerals.Convert(1000));
        }

        [Fact]
        public void When1234ReturnMCCXXXIV()
        {
            Assert.Equal("MCCXXXIV", RomanNumerals.Convert(1234));
        }

        [Fact]
        public void When2234ReturnMCCXXXIV()
        {
            Assert.Equal("MMCCXXXIV", RomanNumerals.Convert(2234));
        }

        [Fact]
        public void When3999ReturnMMMCMXCIX()
        {
            Assert.Equal("MMMCMXCIX", RomanNumerals.Convert(3999));
        }

        [Fact]
        public void When4000ReturnException()
        {
            Assert.Throws<OverflowException>(() => RomanNumerals.Convert(4000));
        }
    }
}
