using NUnit.Framework;
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
        public void Add_TakesEmptyString_ReturnsZero(string numberString, int expectedOutcome)
        {
            var calc = new StringCalculator();

            var result = calc.Add(numberString);

            Assert.AreEqual(expectedOutcome, result);
        }
    }

    public class StringCalculator
    {
        public int Add(string numberString)
        {
            if (string.IsNullOrEmpty(numberString))
            {
                return 0;
            }

            return numberString.Split(',', System.StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum();
        }
    }
}