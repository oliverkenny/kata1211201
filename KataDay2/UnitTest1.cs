using NUnit.Framework;

namespace KataDay2
{
    public class StringCalculatorTests
    {
        [Test]
        public void Add_TakesEmptyString_ReturnsZero()
        {
            var calc = new StringCalculator();

            var result = calc.Add("");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_TakesSingleNumberString_ReturnsAsInt()
        {
            var calc = new StringCalculator();

            var result = calc.Add("1");

            Assert.AreEqual(1, result);
        }
    }

    public class StringCalculator
    {
        public int Add(string numberString)
        {
            return 0;
        }
    }
}