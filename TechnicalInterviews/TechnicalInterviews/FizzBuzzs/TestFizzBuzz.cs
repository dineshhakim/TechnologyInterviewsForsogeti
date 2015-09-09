using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TechnicalInterviews.FizzBuzzs
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [TestCase(2, "2")]
        [TestCase(3, "fizz")]
        [TestCase(5, "buzz")]
        [TestCase(15, "fizzbuzz")]
        [TestCase(30, "fizzbuzz")]
        [TestCase(21, "fizzpop")]
        public void TestNumber(int n, string result)
        {
            var retresult = FizzBuzz.CheckFizzBuzz(n);
            Assert.AreEqual(result, retresult);
        }
    }
}
