namespace Sparky
{
    public class Customer
    {
        public string GreetMessage { get; set; }
        public string GrretAndCombineNames(string firstName,string lastName)
        {
            GreetMessage= "Hello, "+firstName + " " + lastName;
            return GreetMessage;
        }
    }
}
