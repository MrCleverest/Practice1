using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice1.Practice4;

namespace Unit_Tests
{
    [TestClass]
    public class ArraysABTests
    {
        [TestMethod]
        public void Calculate_positive_positive()
        {
            int[] inputArray = { 2, 3 };
            ArraysAB arraysAB = new ArraysAB(inputArray.Length);
            arraysAB.a = inputArray;
            arraysAB.Length = inputArray.Length;

            arraysAB.calculate();

            double[] expectedOutput = { 2.5, 2.5 };
            CollectionAssert.AreEqual(expectedOutput, arraysAB.b);
        }

        [TestMethod]
        public void Calculate_negative_positive()
        {
            int[] inputArray = { -2, 2 };
            ArraysAB arraysAB = new ArraysAB(inputArray.Length);
            arraysAB.a = inputArray;
            arraysAB.Length = inputArray.Length;

            arraysAB.calculate();

            double[] expectedOutput = { 4, 2 };
            CollectionAssert.AreEqual(expectedOutput, arraysAB.b);
        }
        [TestMethod]
        public void Calculate_positive_negative()
        {
            int[] inputArray = { 6, -3 };
            ArraysAB arraysAB = new ArraysAB(inputArray.Length);
            arraysAB.a = inputArray;
            arraysAB.Length = inputArray.Length;

            arraysAB.calculate();

            double[] expectedOutput = { 6, 9 };
            CollectionAssert.AreEqual(expectedOutput, arraysAB.b);
        }

        [TestMethod]
        public void Calculate_negative_negative()
        {
            int[] inputArray = { -2, -3 };
            ArraysAB arraysAB = new ArraysAB(inputArray.Length);
            arraysAB.a = inputArray;
            arraysAB.Length = inputArray.Length;

            arraysAB.calculate();

            double[] expectedOutput = { -1.5, -2.5 };
            CollectionAssert.AreEqual(expectedOutput, arraysAB.b);
        }
    }
}
