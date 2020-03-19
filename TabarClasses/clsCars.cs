using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace TabarClasses
{
    public class clsCars
    {
        private Int32 mCarNo;
        private string mCarMake;
        private string mCarModel;
        private string mCarModelNumber;
        private Int32 mCarPrice;
        private string mCarReleaseDate;
        private string mCarColour;
        private Int32 mCarTypeNumber;
       

        public int CarNo { get { return mCarNo; } set { mCarNo = value; } }
        public string CarMake { get { return mCarMake; } set { mCarMake = value; } }
        public string CarModel { get { return mCarModel; } set { mCarModel = value; } }
        public string CarModelNumber { get { return mCarModelNumber; } set { mCarModelNumber = value; } }
        public int CarPrice { get { return mCarPrice; } set { mCarPrice = value; } }
        public string CarReleaseDate { get { return mCarReleaseDate; } set { mCarReleaseDate = value; } }
        public string CarColour { get { return mCarColour; } set { mCarColour = value; } }
        public int CarTypeNumber { get { return mCarTypeNumber; } set { mCarTypeNumber = value; } }

        public bool Find(int CarNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarNo", CarNo);
            DB.Execute("sproc_tblCars_FilterByCarNo");
            if (DB.Count == 1)
            {
                mCarNo = Convert.ToInt32(DB.DataTable.Rows[0]["CarNo"]);
                mCarMake = Convert.ToString(DB.DataTable.Rows[0]["CarMake"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mCarModelNumber = Convert.ToString(DB.DataTable.Rows[0]["CarModelNumber"]);
                mCarPrice = Convert.ToInt32(DB.DataTable.Rows[0]["CarPrice"]);
                mCarReleaseDate = Convert.ToString(DB.DataTable.Rows[0]["CarReleaseDate"]);
                mCarColour = Convert.ToString(DB.DataTable.Rows[0]["CarColour"]);
                mCarTypeNumber = Convert.ToInt32(DB.DataTable.Rows[0]["CarTypeNumber"]);
                return true;
            }
            else
            {
                return false; 
            }
        }

        public string Valid(string CarMake, string CarModel, string CarModelNumber, string CarColour, string CarReleaseDate)
        {
            String Error = "";
            if (CarMake.Length == 0)
            {
                Error = Error + "The car make can not be blank : ";
            }
            if (CarMake.Length > 3)
            {
                Error = Error + "The car make can not be less than 3 characters ";
            }
            if (CarMake.Length > 40)
            {
                Error = Error + "The car make can not be longer than 40 chracters ";
            }
            return Error;
        }
    }
}