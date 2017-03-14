using System;
using ConsoleApplication3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string palabra = "leepadg";
            long expectedResult = 680131659347;
            long result;
            result=Program.hashfunction(palabra);

            Assert.AreEqual(result,expectedResult);

        }
  
    }
}
