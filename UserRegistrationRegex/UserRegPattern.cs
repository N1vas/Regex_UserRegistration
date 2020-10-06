using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace UserRegistrationRegex
{
    class UserRegPattern
    {
        string firstNameRegex = "[A-Z]{1}[A-Za-z]{2,}";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, firstNameRegex);
        }
    }
}
