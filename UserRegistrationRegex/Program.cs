using System;
using System.Collections.Generic;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName, lastName, email, mobileNo, password;
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
            Console.WriteLine("Enter Mobile No");
            mobileNo = Console.ReadLine();
            bool result4 = pattern.ValidateMobile(mobileNo);
            Console.WriteLine("Validation Check for mobileNo is " + result4);
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
            bool result5 = pattern.ValidatePassword(password);
            Console.WriteLine("Validation Check for password is " + result5);
            List<string> sampleEmailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com",
                "abc+100@gmail.com"
            };
            foreach (string item in sampleEmailList)
            {
                if (pattern.ValidateEmail(item))
                {
                    Console.WriteLine("Valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
    }
}
