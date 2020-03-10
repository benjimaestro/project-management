﻿using System;

namespace TabarClasses
{
    public class clsValidate
    {
        //Class of validation functions
        public static string ValidatePhone(Int32 PhoneNo)
        {
            //Function to validate phone numbers
            string Error = "";
            if (Convert.ToString(PhoneNo).Length > 11 || Convert.ToString(PhoneNo).Length < 7)
            {
                Error = "Phone number must be between 7 and 11 characters <br />";
            }
            return Error;
        }

        public static string ValidateEmail(string EMail)
        {
            //Function to validate EMails, using Microsoft's System.Net.Mail
            string Error = "";
            try
            {
                var addr = new System.Net.Mail.MailAddress(EMail);
                if (EMail.Length > 50) { Error = "Must be under 50 characters <br />"; }
            }
            catch
            {
                Error = "Invalid EMail format <br />";
            }
            return Error;
        }
        public static string ValidateName(string FirstName, string LastName)
        {
            //Function to validate names
            string Error = "";
            if (FirstName == "" || FirstName.Length > 50 || LastName == "" || LastName.Length > 50)
            {
                Error = "Names cannot be blank or over 50 characters <br />";
            }
            return Error;
        }
        public static string ValidateAddress(int HouseNo, string PostCode, string HouseStreet)
        {
            //Function to validate address details including house numbers, UK postcodes and street names
            string Error = "";
            if (HouseNo >= 10000 || HouseNo <= 0)
            { 
                Error = Error + " House number cannot be 0 or below and cannot be 10000 or above <br />";
            }
            if (PostCode.Length > 7 || PostCode.Length < 4)
            {
                Error = Error + " Postcode must be between 4-7 characters <br />";
            }
            if (PostCode.Length > 100 || PostCode.Length < 1)
            {
                Error = Error + " Address must be between 1-50 characters <br />";
            }
            return Error;
        }
        public static string ValidatePassword(string Password, string PasswordConfirm)
        {
            //Function to validate passwords by making sure they're not blank and that the password and confirmation match
            string Error = "";
            if (Password == "" || Password == " ")
            {
                Error = Error + " Password cannot be blank <br />";
            }
            if (Password != PasswordConfirm)
            {
                Error = Error + " Passwords must match <br />";
            }
            return Error;
        }
    }
}