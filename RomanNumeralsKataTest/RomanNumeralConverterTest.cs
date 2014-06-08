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
    }
}