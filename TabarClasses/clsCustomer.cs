using System;
using System.Collections.Generic;
using System.Web;
using System.Security.Cryptography;

namespace TabarClasses
{
    public class clsCustomer
    {
        //Set public properties so they can be accessed from outside the class
        public int CustomerNo { get { return mCustomerNo; } set { mCustomerNo = value; } }
        public int HouseNo { get { return mHouseNo; } set { mHouseNo = value; } }
        public string HouseCounty { get { return mHouseCounty; } set { mHouseCounty = value; } }
        public string PostCode { get { return mPostCode; } set { mPostCode = value; } }
        public string HouseStreet { get { return mHouseStreet; } set { mHouseStreet = value; } }
        public string EMail { get { return mEMail; } set { mEMail = value; } }
        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }
        public string LastName { get { return mLastName; } set { mLastName = value; } }
        public string PhoneNo { get { return mPhoneNo; } set { mPhoneNo = value; } }
        public string Password { get { return mPassword; } set { mPassword = value; } }

        //Set private properties for use inside the class
        private int mCustomerNo;
        private int mHouseNo;
        private string mHouseCounty;
        private string mPostCode;
        private string mHouseStreet;
        private string mEMail;
        private string mFirstName;
        private string mLastName;
        private string mPhoneNo;
        private string mPassword;

        public bool Find(int Id)
        {
            //Function to find a customer's details by their ID and set the properties to be that
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CustomerNo", Id);
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");

            if (DB.Count == 1)
            {
                mCustomerNo =   Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mHouseNo =      Convert.ToInt32(DB.DataTable.Rows[0]["HouseNo"]);
                mHouseCounty =  Convert.ToString(DB.DataTable.Rows[0]["HouseCounty"]);
                mPostCode =     Convert.ToString(DB.DataTable.Rows[0]["HousePostCode"]);
                mHouseStreet =  Convert.ToString(DB.DataTable.Rows[0]["HouseStreet"]);
                mEMail =        Convert.ToString(DB.DataTable.Rows[0]["EMail"]);
                mFirstName =    Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName =     Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPhoneNo =      Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mPassword =     Convert.ToString(DB.DataTable.Rows[0]["HashPassword"]);

                return true;
            }
            else { return false; }
        }
        public string Valid(string HouseNoString, string HouseCounty_, string PostCode_, string HouseStreet_, string EMail_, string FirstName_, string LastName_, string PhoneNoString, string Password_, string PasswordConfirm)
        {
            //Function to call functions in clsValidate, as well as converting some data types
            String Error = "";
            string PhoneNo_ = "1111111";
            int HouseNo_ = 1;

            try
            {
                HouseNo_ = Convert.ToInt32(HouseNoString);
                PhoneNo_ = PhoneNoString;
            }
            catch
            {
                Error = "Phone and house numbers must be integers </br>";
            }

            Error = Error + clsValidate.ValidatePassword(Password_,PasswordConfirm);
            Error = Error + clsValidate.ValidatePhone(PhoneNo_);
            Error = Error + clsValidate.ValidateName(FirstName_, LastName_);
            Error = Error + clsValidate.ValidateEmail(EMail_);
            Error = Error + clsValidate.ValidateHouseNo(HouseNo_);
            Error = Error + clsValidate.ValidatePostCode(PostCode_);
            Error = Error + clsValidate.ValidateStreet(HouseStreet_);

            return Error;
        }
    }
}