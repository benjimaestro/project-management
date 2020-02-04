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
                Error = "Phone number must be between 7 and 11 characters";
            }
            return Error;
        }

        public static string ValidateEmail(string EMail)
        {
            string Error = "";
            try
            {
                var addr = new System.Net.Mail.MailAddress(EMail);
            }
            catch
            {
                Error = "Invalid";
            }
            return Error;
        }
    }
}