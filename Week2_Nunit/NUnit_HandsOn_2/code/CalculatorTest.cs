using System;
using CalcLibrary;
namespace code
{
    [TestFixture]
    public class CalculatorTest
    {
        public SimpleCalculator Calculator { get; set; }

        [SetUp]
        public void Init()
        {
            Calculator = new SimpleCalculator();
        }
        [TearDown]
        public void TearDown()
        {
            Calculator.AllClear();
        }
        [TestCase(5,5,0)]
        [TestCase(5,4,1)]
        [TestCase(9,5,4)]
        public void TestSubtraction(double a,double b,double expected)
        {
            double result = Calculator.Subtraction(a,b);
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(5, 5, 25)]
        [TestCase(5, 4, 20)]
        [TestCase(9, 4, 36)]
        public void TestMultiplication(double a, double b, double expected) 
        { 
            double result = Calculator.Multiplication(a,b);
            Assert.That(result, Is.EqualTo(expected));

        }
        [TestCase(5, 5, 1)]
        [TestCase(5, 2, 2.5)]
        [TestCase(9, 0, 3)]
        public void TestDivision(double a, double b, double expected)
        {
            try
            {
                double result = Calculator.Division(a, b);
                Assert.That(result, Is.EqualTo(expected));
            }
            catch(ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
                Assert.Fail("Division By Zero");
            }
            
        }
            [Test]
            public void TestAddAndClear()
            {
                Calculator.Addition(5, 5);
                Assert.That(10, Is.EqualTo(Calculator.GetResult));
                Calculator.AllClear();
                Assert.That(0, Is.EqualTo(Calculator.GetResult));

            }





    }
}