using System;
using System.Collections.Generic;
namespace TabarClasses
{
    public class clsItemTypeCollection
    {
        //private data member for the allItemType list
        private List<clsItemType> mAllItemType = new List<clsItemType>();

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllItemType.Count;
            }
            set
            {
                //we will look at this in a moment!
            }
        }

        //public property for AllItemType
        public List<clsItemType> AllItemType
        {
            //getter sends the data to requesting code
            get
            {
                //return the private data member
                return mAllItemType;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllItemType = value;
            }
        }

        //public constructor for the class
        public clsItemTypeCollection()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure to get the list of data
            DB.Execute("sproc_tblItemType_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an instance of the itemtype class to store a type
                clsItemType AItemType = new clsItemType();
                //get the colour name
                AItemType.ItemType = DB.DataTable.Rows[Index]["ItemType"].ToString();
                //get the primary key
                AItemType.ItemTypeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemTypeNo"]);
                //add the second colour to the private list of colours
                mAllItemType.Add(AItemType);
                //increment the index
                Index++;
            }
        }
    }
}

