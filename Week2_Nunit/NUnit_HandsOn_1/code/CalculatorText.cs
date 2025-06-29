using System;
using CalcLibrary;
using NUnit.Framework;
namespace code
{
    public class CalculatorTest
    {
        private SimpleCalculator calculator;
        [SetUp]
        public void Init()
        {
            calculator = new SimpleCalculator();
        }
        [TearDown]
        public void Cleanup()
        {
            calculator.AllClear();
        }
        [TestCase(10,5,15)]
        [TestCase(-2, 3, 1)]
        [TestCase(0, 0, 0)]
        public void TestAddition(double a, double b, double expected)
        {
            double actual = calculator.Addition(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [TestCase(15,5,10)]
        [TestCase(10,2,8)]
        [TestCase(8,8,0)]
        public void TestSubtraction(double a, double b, double expected)
        {
            double result = calculator.Subtraction(a, b);
            Assert.That(result,Is.EqualTo(expected));
        }
        [TestCase(2, 2, 4)]
        [TestCase(10, 0, 0)]
        [TestCase(8, 8, 64)]
        public void TestMultiplication(double a, double b, double expected)
        {
            double result = calculator.Multiplication(a, b);
            Assert.That(result,Is.EqualTo(expected));
        }
        //[TestCase(2, 2, 1)]
        //[TestCase(10, 5, 2)]
        //[TestCase(8, 4, 2)]
        //public void TestDivision(double a, double b, double expected)
        //{
        //    double result = calculator.Division(a, b);
        //    Assert.That(result, Is.EqualTo(expected));
        //}
    }
}
