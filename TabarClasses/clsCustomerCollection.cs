using System;
using TabarClasses;
using System.Collections.Generic;

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

            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            DB.AddParameter("@HouseCounty", mThisCustomer.HouseCounty);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@HouseStreet", mThisCustomer.HouseStreet);
            DB.AddParameter("@EMail", mThisCustomer.EMail);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNo", mThisCustomer.PhoneNo);

            return DB.Execute("INSERT SPROC HERE!!!!");

        }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 Recordcount = 0;
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("INSERT SPROC HERE");
            Recordcount = DB.Count;

            while (Index < Recordcount)
            {
                clsCustomer Customer = new clsCustomer();
                Customer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                Customer.HouseNo = Convert.ToInt32(DB.DataTable.Rows[Index]["HouseNo"]);
                Customer.HouseCounty = Convert.ToString(DB.DataTable.Rows[Index]["HouseCounty"]);
                Customer.HouseStreet = Convert.ToString(DB.DataTable.Rows[Index]["HouseStreet"]);
                Customer.EMail = Convert.ToString(DB.DataTable.Rows[Index]["EMail"]);
                Customer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                Customer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);

            }
        }
    }
}