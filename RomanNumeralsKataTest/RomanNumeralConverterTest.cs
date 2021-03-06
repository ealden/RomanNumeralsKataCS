﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralsKataTest
{
    [TestClass]
    public class RomanNumeralConverterTest
    {
        RomanNumeralConverter converter;

        [TestInitialize]
        public void SetUp()
        {
            converter = new RomanNumeralConverter();
        }

        [TestMethod]
        public void ShouldReturn1ForI()
        {
            Assert.AreEqual(1, converter.Convert("I"));
        }

        [TestMethod]
        public void ShouldReturn5ForV()
        {
            Assert.AreEqual(5, converter.Convert("V"));
        }

        [TestMethod]
        [ExpectedException(typeof(UnsupportedRomanNumeralException))]
        public void ShouldThrowExceptionIfRomanNumeralNotSupported()
        {
            converter.Convert("A");
        }

        [TestMethod]
        public void ShouldReturn2ForII()
        {
            Assert.AreEqual(2, converter.Convert("II"));
        }

        [TestMethod]
        public void ShouldReturn3ForIII()
        {
            Assert.AreEqual(3, converter.Convert("III"));
        }

        [TestMethod]
        public void ShouldReturn10ForX()
        {
            Assert.AreEqual(10, converter.Convert("X"));
        }

        [TestMethod]
        public void ShouldReturn50ForL()
        {
            Assert.AreEqual(50, converter.Convert("L"));
        }

        [TestMethod]
        public void ShouldReturn100ForC()
        {
            Assert.AreEqual(100, converter.Convert("C"));
        }

        [TestMethod]
        public void ShouldReturn500ForD()
        {
            Assert.AreEqual(500, converter.Convert("D"));
        }

        [TestMethod]
        public void ShouldReturn1000ForM()
        {
            Assert.AreEqual(1000, converter.Convert("M"));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForIIII()
        {
            converter.Convert("IIII");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForXXXX()
        {
            converter.Convert("XXXX");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForCCCC()
        {
            converter.Convert("CCCC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForMMMM()
        {
            converter.Convert("MMMM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForIIIIII()
        {
            converter.Convert("IIIIII");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfVRepeated()
        {
            converter.Convert("VV");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfLRepeated()
        {
            converter.Convert("LL");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfDRepeated()
        {
            converter.Convert("DD");
        }

        [TestMethod]
        public void ShouldReturn4ForIV()
        {
            Assert.AreEqual(4, converter.Convert("IV"));
        }

        [TestMethod]
        public void ShouldReturn9ForIX()
        {
            Assert.AreEqual(9, converter.Convert("IX"));
        }

        [TestMethod]
        public void ShouldReturn40ForXL()
        {
            Assert.AreEqual(40, converter.Convert("XL"));
        }

        [TestMethod]
        public void ShouldReturn90ForXC()
        {
            Assert.AreEqual(90, converter.Convert("XC"));
        }

        [TestMethod]
        public void ShouldReturn400ForCD()
        {
            Assert.AreEqual(400, converter.Convert("CD"));
        }

        [TestMethod]
        public void ShouldReturn900ForCM()
        {
            Assert.AreEqual(900, converter.Convert("CM"));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForIL()
        {
            converter.Convert("IL");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForIC()
        {
            converter.Convert("IC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForID()
        {
            converter.Convert("ID");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForIM()
        {
            converter.Convert("IM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForXD()
        {
            converter.Convert("XD");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForXM()
        {
            converter.Convert("XM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForVX()
        {
            converter.Convert("VX");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForVL()
        {
            converter.Convert("VL");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForVC()
        {
            converter.Convert("VC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForVD()
        {
            converter.Convert("VD");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForVM()
        {
            converter.Convert("VM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForLC()
        {
            converter.Convert("LC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForLD()
        {
            converter.Convert("LD");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForLM()
        {
            converter.Convert("LM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionForDM()
        {
            converter.Convert("DM");
        }

        [TestMethod]
        public void ShouldReturn1904ForMCMIV()
        {
            Assert.AreEqual(1904, converter.Convert("MCMIV"));
        }

        [TestMethod]
        public void ShouldReturn1954ForMCMLIV()
        {
            Assert.AreEqual(1954, converter.Convert("MCMLIV"));
        }

        [TestMethod]
        public void ShouldReturn1990ForMCMXC()
        {
            Assert.AreEqual(1990, converter.Convert("MCMXC"));
        }

        [TestMethod]
        public void ShouldReturn2014ForMMXIV()
        {
            Assert.AreEqual(2014, converter.Convert("MMXIV"));
        }
    }
}
