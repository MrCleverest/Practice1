using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practice1.Practice3;

namespace Unit_Tests
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void Calculation_D_positive_positive_positive()
        {
            var calc = new Calculation_abc(2, 4, 5);
            var testRes = 121;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_D_negative_positive_positive()
        {
            var calc = new Calculation_abc(-2, 4, 5);
            var testRes = 49;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_D_positive_negative_positive()
        {
            var calc = new Calculation_abc(2, -4, 5);
            var testRes = 9;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_D_positive_positive_negative()
        {
            var calc = new Calculation_abc(2, 4, -5);
            var testRes = 1;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void CalculationD_Negative_negative_negative()
        {
            var calc = new Calculation_abc(-2, -4, -5);
            var testRes = 45;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }
    }
}