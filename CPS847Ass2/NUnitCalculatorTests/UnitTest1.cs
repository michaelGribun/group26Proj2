using NUnit.Framework;
using CPS847Ass2;

namespace NUnitCalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void addTest()
        {
            Assert.AreEqual(Calculator.addThem(1.0, 2.0), 3.0);
        }

        [Test]
        public void subTest()
        {
            Assert.AreEqual(Calculator.subtractThem(4.0, 2.0), 2.0);
        }

        [Test]
        public void multTest()
        {
            Assert.AreEqual(Calculator.multiplyThem(2.0, 2.0), 4.0);
        }

        [Test]
        public void divTest()
        {
            Assert.AreEqual(Calculator.divideThem(20.0, 2.0), 10.0);
        }
    }
}