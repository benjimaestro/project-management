using System;

namespace TabarClasses
{
    public class clsOrder
    {
        //private data member for the Order ID property
        private int mOrderID;
        //private data member for the Item type no property
        private string mItemType;
        //private data member for the Item Name property
        private string mItemName;
        //private data member for the price property
        private int mPrice;
        //private data member for the Quantity property
        private int mQuantity;
        //private data member for the Quality property 
        private Boolean mQuality;
        //private data member for the Date property
        private string mDate;

        //public property for the OrderD
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set value of the private data member
                mOrderID = value;
            }
        }
        //public property for the Item type name
        public string ItemType
        {
            get
            {
                //return the private data
                return mItemType;
            }
            set
            {
                //set the private data
                mItemType = value;
            }
        }
        //public property for the ItemName
        public string ItemName
        {
            get
            {
                //return the private data
                return mItemName;
            }
            set
            {
                //set the private data
                mItemName = value;
            }
        }
        //public property for the Price
        public  Int32 Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }
        //public property for the Quantity
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the private data
                mQuantity = value;
            }
        }
        //public property for the Quality
        public bool Quality
        {
            get
            {
                //return the private data
                return mQuality;
            }
            set
            {
                //set the private data
                mQuality = value;
            }
        }
        //public property for the Date
        public String Date
        {
            get
            {
                //return the private data
                return mDate;
            }
            set
            {
                //set the private data
                mDate = value;
            }
        }
        public bool Find(int OrderID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemType = Convert.ToString(DB.DataTable.Rows[0]["ItemType"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDate = Convert.ToString(DB.DataTable.Rows[0]["Date"]);
                mQuality = Convert.ToBoolean(DB.DataTable.Rows[0]["Quality"]);
                //return that everything is ok
                return true;
            }
            //if no record of found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string ItemName, string Quantity, string Date, string Price)
        {
            //create a string variable to store the erroe
            String Error = "";
            //create a temporary variable to store date values
            //if the ItemName is blank
            if (ItemName.Length == 0)
            {
                //record the error
                Error = Error + "The Item Name may not be blank : ";
            }
            //if the item name is greater than 10 characters
            if (ItemName.Length > 10)
            {
                //record the error
                Error = Error + "The Item Name must be less than 10 characters : ";
            }
            if (Date.Length ==0)
            {
                Error = Error + "The Date may not be blank : ";
            }
            if (Date.Length >10)
            {
                Error = Error + "The Date not be more than 10 characters long : ";
            }
            //is the Quantity blank
            if (Quantity.Length == 0)
            {
                //set the error messsage
                Error = Error + "Quantity is blank. ";
            }
            try
            {
                Int32 TempDec;
                TempDec = Convert.ToInt32(Quantity);
                if (Convert.ToInt32(Quantity) < 100 || Convert.ToInt32(Quantity) > 100)
                {
                    //set the error messsage
                    Error = Error + "Quantity must be more 1 or more";
                }
            }
            catch
            {
                //set an error message
                Error = Error + "Quantity is invalid format. ";
            }
            if (Price.Length == 0)
            {
                //set the error messsage
                Error = Error + "Price is blank. ";
            }
            try
            {
                Int32 TempDec;
                TempDec = Convert.ToInt32(Price);
                if (Convert.ToInt32(Quantity) < 9 || Convert.ToInt32(Quantity) > 10000000)
                {
                    //set the error messsage
                    Error = Error + "Price must be between £9 to 10000000";
                }
            }
            catch
            {
                //set an error message
                Error = Error + "Price is invalid format. ";
            }
            return Error;
            
            
        }

    }
}
