using System;
using System.Collections.Generic;
using System.Web;
using System.Security.Cryptography;

namespace TabarClasses
{
    public class clsCustomer
    {
        public int CustomerNo { get; set; }
        public int HouseNo { get; set; }
        public string HouseCounty { get; set; }
        public string PostCode { get; set; }
        public string HouseStreet { get; set; }
        public string EMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public string Password { get; set; }

        public bool Find(int Id)
        {
            if (Id == CustomerNo) { return true; }
            else { return false; }
        }
        public string Valid(string HouseNoString, string HouseCounty_, string PostCode_, string HouseStreet_, string EMail_, string FirstName_, string LastName_, string PhoneNoString, string Password_, string PasswordConfirm)
        {
            String Error = "";
            Int32 PhoneNo_ = 1111111;
            Int32 HouseNo_ = 1;

            try
            {
                HouseNo_ = Convert.ToInt32(HouseNoString);
                PhoneNo_ = Convert.ToInt32(PhoneNoString);
            }
            catch
            {
                Error = "Phone and house numbers must be integers </br>";
            }

            if (Password_ != PasswordConfirm && Password != "")
            {
                Error = Error + "Passwords must match and cannot be blank </br>";
            }

            Error = Error + clsValidate.ValidatePhone(PhoneNo_);
            Error = Error + clsValidate.ValidateName(FirstName_, LastName_);
            Error = Error + clsValidate.ValidateEmail(EMail_);
            Error = Error + clsValidate.ValidateAddress(HouseNo_,PostCode_,HouseStreet_);

            return Error;
        }
    }
}