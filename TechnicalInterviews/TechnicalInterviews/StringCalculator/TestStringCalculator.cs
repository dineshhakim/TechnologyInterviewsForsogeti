using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TechnicalInterviews.StringCalculator
{
    [TestFixture]
    public class TestStringCalculator
    {
       
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TestNullorEmpty(string numbers)
        {
            var result = StringCalculator.Add(numbers);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        [TestCase("1,2,3", 6)]
        [TestCase("1,2\n3", 6)]
        [TestCase("1,2,\n3", 6)]
        public void TestSum(string numbers, int result)
        {
            var res = StringCalculator.Add(numbers);
            Assert.That(res, Is.EqualTo(result));
        }

        [TestCase("1,-2", -2)]
        [Test]
        public void TestNegative(string numbers, int no)
        {
            var exception = Assert.Throws<ArgumentException>(() => StringCalculator.Add(numbers));

            Assert.That(exception.Message, Is.EqualTo(string.Format(StringCalculator.NegativeException, no)));

        }
        [TestCase("2,5,1001", 7)]
        [TestCase("2,5,1000", 1007)]

        [Test]
        public void TestGreaterthan1000(string numbers, int result)
        {
            var res = StringCalculator.Add(numbers);
            Assert.That(res, Is.EqualTo(result));
        }
    }
}
