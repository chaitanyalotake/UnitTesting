using NUnit.Framework;
using NUnit.Framework.Legacy;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;
        [SetUp]
        public void Setup()
        {
           customer= new Customer();
        }
        

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            ////arrange
            //var customer = new Customer();
            //Act
            string fullName = customer.GrretAndCombineNames("chaitanya", "lotake");
            //assert
            Assert.That(fullName, Is.EqualTo("Hello, chaitanya lotake"));
            Assert.That(fullName, Does.Contain("Chaitanya").IgnoreCase);
            Assert.That(fullName, Does.StartWith("Hello"));
            Assert.That(fullName, Does.EndWith("e"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            ////arrangee
            //var customer=new Customer();
            //act
            //assert
            //string fullName = customer.GrretAndCombineNames("chaitanya", "lotake");
            Assert.That(customer.GreetMessage,Is.Null);
        }
    }
}
