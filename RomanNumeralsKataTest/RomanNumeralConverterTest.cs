using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralsKataTest
{
    [TestClass]
    public class RomanNumeralConverterTest
    {
        [TestMethod]
        public void ShouldReturn1ForI()
        {
            var converter = new RomanNumeralConverter();

            Assert.AreEqual(1, converter.Convert("I"));
        }
    }
}
