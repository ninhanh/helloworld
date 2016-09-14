using System;
using NUnit.Framework;

namespace BuildCI
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("Test method 1");
            Assert.IsTrue(true);
        }

        [Test]
        public void TestMethod2()
        {
            Console.WriteLine("Test method 2");
            Assert.IsTrue(false);
        }

        [Test]
        public void TestMethod3()
        {
            Console.WriteLine("Test method 3");
            Assert.IsTrue(true);
        }
    }
}
