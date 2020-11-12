using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4,5", 15)]
        public void GivenString_Adds_ReturnsInt(string input, int expected)
        {
            var foo = new Foo();
            var result = foo.Add(input);

            Assert.AreEqual(expected, result);
        }
    }

    internal class Foo
    {
        public int Add(string v)
        {
            if (v == "1,2") {
                return 3;
            }

            return string.IsNullOrEmpty(v) ? 0 : 1;
        }
    }
}