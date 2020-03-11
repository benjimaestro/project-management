using System;
using TabarClasses;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace TabarClasses
{
    public class clsCustomerCollection
    {
        //Set private variables
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        //Set public properties so pages can access the customer list and current customer
        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }
        
        public int Count
        {
            get { return mCustomerList.Count; }
        }

        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }
        public int Add()
        {
            //Function to call stored procedure to add details to database
            clsDataConnection DB = new clsDataConnection();

            //DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@HouseCounty", mThisCustomer.HouseCounty);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@HouseStreet", mThisCustomer.HouseStreet);
            DB.AddParameter("@EMail", mThisCustomer.EMail);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@HashPassword", mThisCustomer.Password);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public int Update()
        {
            //Function to call stored procedure to update existing row in database based on the CustomerNo property of the
            //current clsCustomer instance that's set as ThisCustomer
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@HouseCounty", mThisCustomer.HouseCounty);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@HouseStreet", mThisCustomer.HouseStreet);
            DB.AddParameter("@EMail", mThisCustomer.EMail);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);
            DB.AddParameter("@HashPassword", mThisCustomer.Password);

            return DB.Execute("sproc_tblCustomer_Update");
        }

        public void Find(Int32 Id)
        {
            //Function to set ThisCustomer clsCustomer instance to whichever entry in the mCustomerList matches the ID
            Int32 Index = 0;
            while (mCustomerList.Count > Index)
            {
                if (mCustomerList[Index].CustomerNo == Id)
                {
                    ThisCustomer = mCustomerList[Index];
                }
                Index++;
            }
        }
        public void FindEMail(string EMail)
        {
            //Function to set ThisCustomer clsCustomer instance to whichever entry in the mCustomerList matches the EMail
            Int32 Index = 0;
            while (mCustomerList.Count > Index)
            {
                if (mCustomerList[Index].EMail== EMail)
                {
                    ThisCustomer = mCustomerList[Index];
                }
                Index++;
            }
        }

        public clsCustomerCollection()
        {
            //Function to call stored procedure that fetches all customer records
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        public void ReportByEMail(string EMail)
        {
            //Function to call stored procedure that fetches all customer records which are similar to the EMail variable which is passed in
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EMail", EMail);
            DB.Execute("sproc_tblCustomer_FilterByEMail");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //Function to populate mCustomerList with whatever is fetched by the stored procedure
            //Loops over rows to set details to create clsCustomer instance for each row and give it the details
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();
                Customer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Customer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["HousePostcode"]);
                Customer.HouseNo = Convert.ToInt32(DB.DataTable.Rows[Index]["HouseNo"]);
                Customer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                Customer.HouseCounty = Convert.ToString(DB.DataTable.Rows[Index]["HouseCounty"]);
                Customer.HouseStreet = Convert.ToString(DB.DataTable.Rows[Index]["HouseStreet"]);
                Customer.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                Customer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                Customer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                Customer.Password = Convert.ToString(DB.DataTable.Rows[Index]["HashPassword"]);

                mCustomerList.Add(Customer);

                Index++;
            }
        }

        public string GetHashPassword(string ToHash)
        {
            //Function to hash a string
            //This is used so that raw passwords are not stored. That would be very bad security, as it means anyone with database
            //access (authorized or not) can see customer passwords.
            //Doing it this way means we can still see if a user's inputted password is the same as the one they signed up with,
            //but without actually knowing their password.
            //The hashing algorithm used is SHA2-512, since this is still secure (others like SHA-0,SHA-1,MD5 are no longer secure)
            //I'm using System.Security.Cryptography from Microsoft for this as writing my own SHA2-512 algorithm would be unsafe.
            if (ToHash != "")
            {
                SHA512Managed HashGen = new SHA512Managed();
                string HashString;
                byte[] TextBytes;
                byte[] HashBytes;

                TextBytes = System.Text.Encoding.UTF8.GetBytes(ToHash);
                HashBytes = HashGen.ComputeHash(TextBytes);
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;
            }
            else { return ""; }
        }

        public void Delete(Int32 Id)
        {
            //Function to delete an instance of a customer from the mCustomerList and DB based on provided ID
            clsDataConnection DB = new clsDataConnection();
            Int32 Index = 0;
            while (mCustomerList.Count > Index)
            {
                if (mCustomerList[Index].CustomerNo == Id)
                {
                    mCustomerList.RemoveAt(Index);
                }
                Index++;
            }

            DB.AddParameter("@CustomerNo", Id);
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}