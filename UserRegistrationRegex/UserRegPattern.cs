using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace UserRegistrationRegex
{
    class UserRegPattern
    {
        string nameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        string emailRegex = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string mobileRegex = "^[1-9]{1}[0-9]{1,2}[ ]{1}[6-9]{1}[0-9]{9}$";
        string passwordRegex = "(?=[A-Za-z0-9]+$)^(?=.*[A-Z])(?=.*[0-9])(?=.{8,}).*$";
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
        public bool ValidateMobile(string mobileNo)
        {
            return Regex.IsMatch(mobileNo, mobileRegex);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, passwordRegex);
        }
    }
}
