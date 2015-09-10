using NUnit.Framework;

namespace TechnicalInterviews.RomanNumerals
{
    [TestFixture]
    public class TestRomanNumeral
    {
        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]

        [TestCase(1066, "MLXVI")]
        [TestCase(1989, "MCMLXXXIX")]
        public void CheckArabicToRoman(int n, string res)
        {
            var result = RomanNumeral.ArabicToRoman(n);
            Assert.That(result, Is.EqualTo(res));
        }
         [TestCase("I", 1)]
        public void CheckRomanToArabic(string roman, int res)
        {
            var result = RomanNumeral.RomanToArabic(roman);
            Assert.That(result, Is.EqualTo(res));
        }
    }
}