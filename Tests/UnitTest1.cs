using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
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
            return string.IsNullOrEmpty(v) ? 0 : 1;
        }
    }
}