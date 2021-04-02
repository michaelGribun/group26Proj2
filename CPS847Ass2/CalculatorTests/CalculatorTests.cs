using CPS847Ass2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void addTest()
        {
            Assert.AreEqual(Calculator.addThem(1.0, 2.0), 3.0);
        }

        [TestMethod]
        public void subTest()
        {
            Assert.AreEqual(Calculator.subtractThem(4.0, 2.0), 2.0);
        }

        [TestMethod]
        public void multTest()
        {
            Assert.AreEqual(Calculator.multiplyThem(2.0, 2.0), 4.0);
        }

        [TestMethod]
        public void divTest()
        {
            Assert.AreEqual(Calculator.divideThem(20.0, 2.0), 10.0);
        }
    }
}
