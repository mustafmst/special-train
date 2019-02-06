using ArabicToRoman;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Converter converter;
        
        [SetUp]
        public void SetUp()
        {
            converter = new Converter();
        }

        [TestCase(1,"I")]
        [TestCase(5,"V")]
        [TestCase(10,"X")]
        public void ToRoman_ReturnsSignForBasicRomanNumbers(decimal given, string expected)
        {
            var actual = converter.ToRoman(given);

            Assert.AreEqual(expected, actual);
        }
    }
}