using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3,4,5", 15)]
        [TestCase("1\n2,3", 6)]
        [TestCase("//;\n1;2", 3)]
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
            if (string.IsNullOrEmpty(v))
            {
                return 0;
            }

            return v.Split(new char[] {',', '\n'}, System.StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum();
        }
    }
}