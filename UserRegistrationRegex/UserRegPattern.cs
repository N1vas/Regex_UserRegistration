using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace UserRegistrationRegex
{
    class UserRegPattern
    {
        string nameRegex = "[A-Z]{1}[A-Za-z]{2,}";
        string emailRegex = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, nameRegex);
        }
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, nameRegex); 
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, emailRegex);
        }
    }
}
