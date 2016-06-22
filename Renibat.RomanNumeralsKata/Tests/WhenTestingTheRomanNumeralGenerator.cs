using NUnit.Framework;
using Renibat.RomanNumeralsKata.Services;

namespace Renibat.RomanNumeralsKata.Tests
{
    [TestFixture]
    public class WhenTestingTheRomanNumeralGenerator
    {
        protected RomanNumeralGenerator RomanNumeralGenerator { get; set; }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(3999, "MMMCMXCIX")]
        public void ThenCorrectRomanNumeralsAreReturnedForNumber(int inputNumber, string expectedResult)
        {
            var romanNumeralGenerator = new RomanNumeralGenerator();

            var result = romanNumeralGenerator.Generate(inputNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }    
}
