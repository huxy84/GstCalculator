using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GstCalculatorTests
{
    [TestClass]
    public class GstCalculatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Input must be a numberic value")]
        public void InputHasMoreThanOneDecimalPointThrowsArgumentExceptionSuccess()
        {
            var input = "1.2.3";

            CalculateGst(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Amount must be greater than zero")]
        public void MyTestMethod()
        {
            var input = "-12";

            CalculateGst(input);
        }

        [TestMethod]
        public void InputTenReturnsOneSuccess()
        {
            const string input = "10";

            var result = CalculateGst(input);

            const double expectedResult = 1;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void InputOneHundredReturnsTenSuccess()
        {
            const string input = "100";

            var result = CalculateGst(input);

            const double expectedResult = 10;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void InputFourtyFiveReturnsFourPointFiveSuccess()
        {
            const string input = "45";

            var result = CalculateGst(input);

            const double expectedResult = 4.5;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void InputOnePointTwoThreeReturnsZeroPointSuccess()
        {
            const string input = "1.23";

            var result = CalculateGst(input);

            const double expectedResult = 0.123;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void InputOneTwoThreePointFourFiveSixReturnsOneTwoPointThreeFourFiveSizeSuccess()
        {
            const string input = "123.456";

            var result = CalculateGst(input);

            const double expectedResult = 12.3456;

            Assert.AreEqual(expectedResult, result);
        }

        private static double CalculateGst(string input)
        {
            return GstCalculator.GstCalculator.CalculateGst(input);
        }
    }
}
