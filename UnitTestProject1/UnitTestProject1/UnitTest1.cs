using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Assert.ReferenceEquals(3, Class1.MaxInt(new int[] {1, 2, 3}));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ReferenceEquals(1, Class1.MaxInt(new int[] {1,1,1}));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.ReferenceEquals(0, Class1.MaxInt(new int[] { }));
        }
        
    }
}
