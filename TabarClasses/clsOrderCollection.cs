using System;
using System.Collections.Generic;

namespace TabarClasses
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();

        //public property for the Order List
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this latter
            }
        }

        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        //constructor for the class
        public clsOrderCollection()
        {
            //object for the data Connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@ItemType", mThisOrder.ItemType);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@Quality", mThisOrder.Quality);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            //execute the query returning the primary key data
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //delete the record from sql database by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            //execute the store procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //Update a existing record to the database from thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@ItemType", mThisOrder.ItemType);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@Quality", mThisOrder.Quality);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByItemType(string ItemType)
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the model parameter to the database
            DB.AddParameter("@ItemType", ItemType);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByItemType");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrder AOrder = new clsOrder();
                //read in the field from the current record
                AOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AOrder.ItemType = Convert.ToString(DB.DataTable.Rows[Index]["ItemType"]);
                AOrder.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AOrder.Quality = Convert.ToBoolean(DB.DataTable.Rows[Index]["Quality"]);
                AOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AOrder.Date = Convert.ToString(DB.DataTable.Rows[Index]["Date"]);
                mOrderList.Add(AOrder);
                //loop this code for the next record
                Index++;
            }
        }

    }
}
