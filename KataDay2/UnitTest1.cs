using NUnit.Framework;
using System;

namespace KataDay2
{
    public class Tests
    {

        [Test]
        public void Add_TakesEmpty_ReturnsZero()
        {
            var k = new Kata();

            var result = k.Add("");

            Assert.AreEqual(0, result);
        }
    }

    public class Kata
    {
        public int Add(string v)
        {
            throw new NotImplementedException();
        }
    }
}