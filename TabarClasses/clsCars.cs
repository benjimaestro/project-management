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
            if (CarMake.Length < 3)
            {
                Error = Error + "The car make can not be less than 3 characters ";
            }
            if (CarMake.Length > 40)
            {
                Error = Error + "The car make can not be longer than 40 chracters ";
            }
            if (CarModel.Length == 0)
            {
                Error = Error + "The car model can not be blank :";
            }
            if (CarModel.Length < 1)
            {
                Error = Error + "The car model can not be less than 1 character";
            }
            if (CarModel.Length > 45 )
            {
                Error = Error + "The car model can not be more than 45 characters";
            }
            if (CarModelNumber.Length == 0)
            {
                Error = Error + "The car model number can not be blank :";
            }
            if (CarModelNumber.Length < 1)
            {
                Error = Error + "The car model number can not be less than 1 character";
            }
            if (CarModelNumber.Length > 7)
            {
                Error = Error + "The car model can not be more than 7 characters";
            }
            if (CarColour.Length == 0)
            {
                Error = Error + "The car colour can not be blank :";
            }
            if (CarColour.Length < 3)
            {
                Error = Error + "The car colour can not be less than 3 character";
            }
            if (CarColour.Length > 25)
            {
                Error = Error + "The car model can not be more than 25 characters";
            }
            if (CarReleaseDate.Length == 0)
            {
                Error = Error + "The car release date can not be blank :";
            }
            if (CarColour.Length < 10)
            {
                Error = Error + "The car release date can not be less than 10 character, use DD/MM/YYYY";
            }
            if (CarColour.Length > 10)
            {
                Error = Error + "The car release date can not be more than 10 characters, use DD/MM/YYYY";
            }

            return Error;
        }
    }
}