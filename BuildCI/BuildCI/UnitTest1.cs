using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuildCI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Test method 1");
            Assert.Equals("1", "1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Test method 1");
            Assert.Equals("1", "2");
        }
    }
}
