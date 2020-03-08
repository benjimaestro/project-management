using System;
using TabarClasses;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace TabarClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

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

        public List<clsCustomer> GetCustomer(int v)
        {
            throw new NotImplementedException();
        }

        public void Find(Int32 Id)
        {
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

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        public void ReportByEMail(string EMail)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@EMail", EMail);
            DB.Execute("sproc_tblCustomer_FilterByEMail");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
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
                Customer.HouseCounty = Convert.ToString(DB.DataTable.Rows[Index]["HouseCounty"]);
                Customer.HouseStreet = Convert.ToString(DB.DataTable.Rows[Index]["HouseStreet"]);
                Customer.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                Customer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                Customer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);

                mCustomerList.Add(Customer);

                Index++;
            }
        }

        public string GetHashPassword(string ToHash) //Function to securely hash text with the Cryptography library
        {
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