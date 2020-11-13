using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KataDay2
{
    public class StringCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4,5", 15)]
        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
        public void Add_TakesNumberString_ReturnsSumAsInt(string numberString, int expectedOutcome)
        {
            var calc = new StringCalculator();

            var result = calc.Add(numberString);

            Assert.AreEqual(expectedOutcome, result);
        }

        [TestCase("1,-2", "negatives are not allowed -2")]
        [TestCase("-1,-2,-3", "negatives are not allowed -1 -2 -3")]
        public void Add_TakesNegativeNumber_ThrowsException(string numberString, string exceptionMessage) {
            var calc = new StringCalculator();

            var exception = Assert.Throws<Exception>(() => calc.Add(numberString));

            Assert.AreEqual(exceptionMessage, exception.Message);
        }
    }

    public class StringCalculator
    {
        public int Add(string numberString)
        {
            var delims = new List<char> { ',', '\n' };

            if (numberString.StartsWith("//")) {
                delims.Add(numberString[2]);
                numberString = numberString.Substring(3);
            }

            return numberString.Split(delims.ToArray(), System.StringSplitOptions.RemoveEmptyEntries).Select(x =>
            {
                var num = int.Parse(x);
                if (num < 0)
                {
                    throw new Exception("negatives are not allowed " + x.ToString());
                }
                return num;
            }).Sum();
        }
    }
}