using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator gradingCalculator;
        [SetUp]
        public void Setup()
        {
            gradingCalculator = new GradingCalculator();
        }
        [Test]
        [TestCase(95, 90)]
        public void Grade_A_Calculator_InputAttendanceAndPercentage(int percentage, int attedance)
        {
            gradingCalculator.AttendancePercentage = attedance;
            gradingCalculator.Score = percentage;
            string result = gradingCalculator.GetGrade();

            Assert.That(result, Is.EqualTo("A"));
        }

        [Test]
        [TestCase(85, 90)]
        [TestCase(95, 65)]
        public void Grade_B_Calculator_InputAttendanceAndPercentage(int percentage, int attedance)
        {
            gradingCalculator.AttendancePercentage = attedance;
            gradingCalculator.Score = percentage;
            string result = gradingCalculator.GetGrade();

            Assert.That(result, Is.EqualTo("B"));
        }

        [Test]
        [TestCase(65, 90)]
        public void Grade_C_Calculator_InputAttendanceAndPercentage(int percentage, int attedance)
        {
            gradingCalculator.AttendancePercentage = attedance;
            gradingCalculator.Score = percentage;
            string result = gradingCalculator.GetGrade();

            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        [TestCase(95, 55)]
        [TestCase(65, 55)]
        [TestCase(50, 90)]
        public void Grade_F_Calculator_InputAttendanceAndPercentage(int percentage, int attedance)
        {
            gradingCalculator.AttendancePercentage = attedance;
            gradingCalculator.Score = percentage;
            string result = gradingCalculator.GetGrade();

            Assert.That(result, Is.EqualTo("F"));
        }


        [Test]
        [TestCase(95, 55,ExpectedResult ="F")]
        [TestCase(65, 55,ExpectedResult ="F")]
        [TestCase(50, 90,ExpectedResult ="F")]
        [TestCase(85, 90,ExpectedResult ="B")]
        [TestCase(95, 65,ExpectedResult ="B")]
        [TestCase(65, 90,ExpectedResult ="C")]
        [TestCase(95,90,ExpectedResult ="A")]

        public string GradeCalculator_ForAllGrade_InputAttendanceAndPercentage(int percentage, int attedance)
        {
            gradingCalculator.AttendancePercentage = attedance;
            gradingCalculator.Score = percentage;
            return gradingCalculator.GetGrade();
        }


    }
}
