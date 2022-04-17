using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Services;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int Odin = 1;
            int Dva = 4;
            int Tri = 3;

            string Result = Square.SquareReshenie(Odin, Dva, Tri);
            Assert.AreEqual("x1=-1, x2=-3", Result);

        }
    }
}
