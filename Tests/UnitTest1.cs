using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GivenEmpty_ReturnsZero()
        {
            var foo = new Foo();
            var result = foo.Add("");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void GivenOne_ReturnsOne()
        {
            var foo = new Foo();
            var result = foo.Add("1");

            Assert.AreEqual(1, result);
        }
    }

    internal class Foo
    {
        public Foo()
        {
        }

        public int Add(string v)
        {
            return 0;
        }
    }
}