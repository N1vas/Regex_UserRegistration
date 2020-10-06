using System;
namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            Console.WriteLine("Enter First Name");
            firstName = Console.ReadLine();
            UserRegPattern pattern = new UserRegPattern();
            bool result = pattern.ValidateFirstName(firstName);
            Console.WriteLine("Validation Check for first name is "+ result);
        }
    }
}
