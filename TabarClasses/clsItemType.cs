using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabarClasses
{
    public class clsItemType
    {
        //private data member for the colour no property
        private int mItemTypeNo;
        //private data member for the Colour Name property
        private string mItemType;

        //public property for the ColourNo
        public int ItemTypeNo
        {
            get
            {
                //return the private data
                return mItemTypeNo;
            }
            set
            {
                //set the private data
                mItemTypeNo = value;
            }
        }
        //public roperty for the CarName
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

        public string Valid(string someItemName)
        {
            //sttring variable to store the error message
            string Error = "";
            //if the name of the colour is more than 16
            if (someItemName.Length > 50)
            {
                //return an error message
                Error = "The Item Type cannot be more than 10 characters";
            }
            if (someItemName.Length == 0)
            {
                //return an error message
                Error = "The Item Type may not be blank!";
            }
            return Error;
        }

        public bool Find(int ItemTypeNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the colour no to search for
            DB.AddParameter("@ItemTypeNo", ItemTypeNo);
            //execute the store procedure
            DB.Execute("sproc_tblItemType_FilterByItemTypeNo");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mItemTypeNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemTypeNo"]);
                mItemType = Convert.ToString(DB.DataTable.Rows[0]["ItemType"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}

