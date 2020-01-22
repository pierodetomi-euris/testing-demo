using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingDemo.UnitTests
{
    [TestClass]
    public class CalculatorTests_Add
    {
        [TestMethod]
        public void BothOperandsPositive_PositiveResult()
        {
            #region Arrange

            decimal operand1 = 10;
            decimal operand2 = 5;

            #endregion

            #region Act

            Calculator calculator = new Calculator { };
            decimal result = calculator.Add(operand1, operand2);

            #endregion

            #region Assert

            Assert.AreEqual(15, result);
            
            #endregion
        }

        [TestMethod]
        public void BothOperandsZero_ZeroResult()
        {
            #region Arrange

            decimal operand1 = 0;
            decimal operand2 = 0;

            #endregion

            #region Act

            Calculator calculator = new Calculator { };
            decimal result = calculator.Add(operand1, operand2);

            #endregion

            #region Assert

            Assert.AreEqual(0, result);

            #endregion
        }
    }
}