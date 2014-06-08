using System;
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
        public void ShouldThrowExceptionIfIIII()
        {
            converter.Convert("IIII");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfXXXX()
        {
            converter.Convert("XXXX");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfCCCC()
        {
            converter.Convert("CCCC");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfMMMM()
        {
            converter.Convert("MMMM");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidRomanNumeralStringException))]
        public void ShouldThrowExceptionIfIIIIII()
        {
            converter.Convert("IIIIII");
        }
    }
}
