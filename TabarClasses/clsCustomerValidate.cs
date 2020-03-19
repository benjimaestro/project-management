using System;

namespace TabarClasses
{
    public class clsCustomerValidate
    {
        public static string ValidatePhone(string PhoneNo)
        {
            //Makes sure inputted data is correct for a phone number
            string Error = "";
            if (PhoneNo.Length > 11 || PhoneNo.Length < 7)
            {
                Error = "Phone number must be between 7 and 11 characters <br />";
            }
            return Error;
        }

        public static string ValidateEmail(string EMail)
        {
            //Makes sure inputted data is correct for an EMail
            string Error = "";
            try
            {
                var addr = new System.Net.Mail.MailAddress(EMail);
                if (EMail.Length > 100 || EMail.Length < 6) { Error = "Must be under 100 characters and over 6 characters <br />"; }
            }
            catch
            {
                Error = "Invalid EMail format <br />";
            }
            return Error;
        }
        public static string ValidateName(string FirstName, string LastName)
        {
            //Makes sure inputted data is correct for first and last names
            string Error = "";
            if (FirstName == "" || FirstName.Length > 50 || LastName == "" || LastName.Length > 50)
            {
                Error = "Names cannot be blank or over 50 characters <br />";
            }
            return Error;
        }
        public static string ValidateHouseNo(int HouseNo)
        {
            //Makes sure inputted data is correct for UK house numbers
            string Error = "";
            if (HouseNo >= 10000 || HouseNo <= 0)
            { 
                Error = Error + " House number must be between 1-10000 <br />";
            }
            return Error;
        }
        public static string ValidatePostCode(string PostCode)
        {
            //Makes sure inputted data is correct for a UK postcode
            string Error = "";
            if (PostCode.Length > 7 || PostCode.Length < 4)
            {
                Error = Error + " Postcode must be between 4-7 characters <br />";
            }
            return Error;
        }
        public static string ValidateCounty(string PostCode)
        {
            //Makes sure inputted data is correct for a UK county name
            string Error = "";
            if (PostCode.Length > 26 || PostCode.Length < 4)
            {
                Error = Error + " County must be between 4 and 26 characters <br />";
            }
            return Error;
        }
        public static string ValidateStreet(string HouseStreet)
        {
            //Makes sure inputted data is correct for a street name
            string Error = "";
            if (HouseStreet.Length > 100 || HouseStreet.Length < 1)
            {
                Error = Error + " Address must be between 1-50 characters <br />";
            }
            return Error;
        }
        public static string ValidatePassword(string Password, string PasswordConfirm)
        {
            //Makes sure inputted passwords match and aren't blank
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