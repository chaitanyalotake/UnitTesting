using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            //Calculator calculator = new Calculator();

            //Act
            int result = calculator.AddNumbers(10, 20);

            //Assert
            ClassicAssert.AreEqual(30, result);
        }

        [Test]
        public void IsOddNumber_InputEvenNumber_ReturnFalse()
        {
            //Calculator calculator=new Calculator();
            bool result = calculator.IsOddNumber(10);
            ClassicAssert.That(result,Is.EqualTo(false));
            ClassicAssert.IsFalse(result);
        }

        [Test]
        [TestCase(11)]
        [TestCase(15)]
        [TestCase(13)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int a)
        {
            //Calculator calculator = new Calculator();
            bool result = calculator.IsOddNumber(a);
            ClassicAssert.That(result, Is.EqualTo(true));
            
        }

        [Test]
        [TestCase(2, ExpectedResult =false)]
        [TestCase(1,ExpectedResult =true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int n)
        {
            //Calculator calculator = new Calculator();
            return calculator.IsOddNumber(n);
        }

        [Test]
        [TestCase(5.4,10.5)]
        [TestCase(5.43,10.53)]
        [TestCase(5.49,10.59)]
        public void AddNumbers_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            //Calculator calculator = new Calculator();

            //Act
            double result = calculator.AddNumbersDouble(a,b);

            //Assert
            ClassicAssert.AreEqual(15.9, result,.2);
        }

        [Test]
        public void OddRange_InputMinAndMaxRange_ReturnValidOddNumberRange()
        {
            List<int> expectedOddRange = new List<int>() { 5, 7, 9 };//arrange

            List<int> result = calculator.GetOddRange(5, 10);//act

            Assert.That(result,Is.EquivalentTo(expectedOddRange));
            Assert.That(result, Is.Ordered);
        }
    }
}
