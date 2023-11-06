using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practice1.Practice3;

namespace Unit_Tests
{
    [TestClass]
    public class IntervalTest
    {
        [TestMethod]
        public void Counting_29()
        {
            var calc = new Interval(1, 150);
            var testRes = 5;
            var res = calc.Count(29, 0);
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Counting_2()
        {
            var calc = new Interval(1, 150);
            var testRes = 74;
            var res = calc.Count(2, 0);
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Counting_5()
        {
            var calc = new Interval(1, 150);
            var testRes = 30;
            var res = calc.Count(5, 2);
            Assert.AreEqual(testRes, res);
        }
    }
}
