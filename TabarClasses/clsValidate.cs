using System;

namespace TabarClasses
{
    public class clsValidate
    {
        public static string ValidatePhone(Int32 PhoneNo)
        {
            string Error = "";
            if (Convert.ToString(PhoneNo).Length > 11 || Convert.ToString(PhoneNo).Length < 7)
            {
                Error = "Phone number must be between 7 and 11 characters <br />";
            }
            return Error;
        }

        public static string ValidateEmail(string EMail)
        {
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
            string Error = "";
            if (FirstName == "" || FirstName.Length > 50 || LastName == "" || LastName.Length > 50)
            {
                Error = "Names cannot be blank or over 50 characters <br />";
            }
            return Error;
        }
        public static string ValidateAddress(int HouseNo, string PostCode, string HouseStreet)
        {
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
    }
}