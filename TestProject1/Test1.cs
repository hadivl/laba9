using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public sealed class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void TestInitialize()
        {

            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {

            double a = 5;
            double b = 3;
            double expected = 8;

            double actual = _calculator.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            double a = 10;
            double b = 0;

            Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [TestMethod]
        [DataRow(2, 3, 8)]
        [DataRow(3, 2, 9)]
        [DataRow(5, 0, 1)]
        public void Power_ReturnsCorrectResult(double num, double power, double expected)
        {

            double result = _calculator.Power(num, power);

            Assert.AreEqual(expected, result, delta: 0.001); 
        }
    }
}