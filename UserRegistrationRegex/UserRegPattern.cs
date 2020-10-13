using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace UserRegistrationRegex
{
    public class UserRegPattern
    {
        string nameRegex = "^[A-Z]{1}[A-Za-z]{2,}$";
        string emailRegex = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string mobileRegex = "^[1-9]{1}[0-9]{1,2}[ ]{1}[6-9]{1}[0-9]{9}$";
        string passwordRegex = "^(?=.*?[._+-@#&*$])(?=.*[A-Z])(?=.*[0-9])([0-9a-zA-z]{8,})$";
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, nameRegex))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, nameRegex))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
        }
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, emailRegex))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        }
        public bool ValidateMobile(string mobileNo)
        {
            if (Regex.IsMatch(mobileNo, mobileRegex))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, passwordRegex))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }
    }
}
