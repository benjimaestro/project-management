using System;

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

        public String Valid(string HouseNoString, string HouseCounty_, string PostCode_, string HouseStreet_, string EMail_, string FirstName_, string LastName_, string PhoneNoString)
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
                Error = "Phone and house numbers must be integers ";
            }

            Error = Error + clsValidate.ValidatePhone(PhoneNo_);
            Error = Error + clsValidate.ValidateName(FirstName_, LastName);
            Error = Error + clsValidate.ValidateEmail(EMail_);
            Error = Error + clsValidate.ValidateAddress(HouseNo_,PostCode_,HouseStreet_);

            return Error;
        }
    }
}