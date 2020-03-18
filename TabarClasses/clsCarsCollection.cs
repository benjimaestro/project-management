
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace TabarClasses
{
    public class clsCarsCollection
    {
        
        List<clsCars> mCarList = new List<clsCars>();
        clsCars mThisCar = new clsCars(); 
        public clsCarsCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCars_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCars ACar = new clsCars();
                ACar.CarNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CarNo"]);
                ACar.CarMake = Convert.ToString(DB.DataTable.Rows[Index]["CarMake"]);
                ACar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                ACar.CarModelNumber = Convert.ToString(DB.DataTable.Rows[Index]["CarModelNumber"]);
                ACar.CarPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["CarPrice"]);
                ACar.CarReleaseDate = Convert.ToString(DB.DataTable.Rows[Index]["CarReleaseDate"]);
                ACar.CarColour = Convert.ToString(DB.DataTable.Rows[Index]["CarColour"]);
                ACar.CarTypeNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["CarTypeNumber"]);
                mCarList.Add(ACar);
                Index++;
            }

        }



        public List<clsCars> CarList
        {
            get
            {
                return mCarList;
            }
            set
            {
                mCarList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCarList.Count;
            }
            set
            {

            }
        }
        public clsCars ThisCar 
        {
            get
            {
                return mThisCar; 
            }
            set
            {
                mThisCar = value; 
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarModelNumber", mThisCar.CarModelNumber);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarPrice", mThisCar.CarPrice);
            DB.AddParameter("@CarTypeNumber", mThisCar.CarTypeNumber);
            DB.AddParameter("@CarReleaseDate", mThisCar.CarReleaseDate);
            return DB.Execute("sproc_tblCars_Insert");
        }
    }
}