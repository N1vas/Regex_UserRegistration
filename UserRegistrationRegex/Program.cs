using System;
namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName, lastName, email;
            Console.WriteLine("Enter First Name");
            firstName = Console.ReadLine();
            UserRegPattern pattern = new UserRegPattern();
            bool result1 = pattern.ValidateFirstName(firstName);
            Console.WriteLine("Validation Check for first name is "+ result1);
            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();
            bool result2 = pattern.ValidateFirstName(lastName);
            Console.WriteLine("Validation Check for last name is " + result2);
            Console.WriteLine("Enter Email ID");
            email = Console.ReadLine();
            bool result3 = pattern.ValidateEmail(email);
            Console.WriteLine("Validation Check for email is " + result3);
        }
    }
}
