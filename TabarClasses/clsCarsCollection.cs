
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
        Int32 CarNo; 
        List<clsCars> mCarList = new List<clsCars>();
        clsCars mThisCar = new clsCars(); 
        public clsCarsCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCars_SelectAll");
            PopulateArray(DB); 
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

        public Boolean Delete(Int32 CarNo)
        {
            try
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@CarNo", CarNo);
                DB.Execute("sproc_tblCars_Delete");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarNo", mThisCar.CarNo);
            DB.Execute("sproc_tblCars_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarNo", mThisCar.CarNo);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@CarModelNumber", mThisCar.CarModelNumber);
            DB.AddParameter("@CarColour", mThisCar.CarColour);
            DB.AddParameter("@CarPrice", mThisCar.CarPrice);
            DB.AddParameter("@CarTypeNumber", mThisCar.CarTypeNumber);
            DB.AddParameter("@CarReleaseDate", mThisCar.CarReleaseDate);
            DB.Execute("sproc_tblCars_Update");
        }

        public void ReportByCarMake(string CarMake)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarMake", CarMake);
            DB.Execute("sproc_tblCars_FilterByCarMake");
            PopulateArray(DB);
        }

        public void ReportByCarColour(string CarColour)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarColour", CarColour);
            DB.Execute("sproc_tblCars_FilterByCarColour");
            PopulateArray(DB);
        }

        public void ReportByCarModel(string CarModel)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CarModel", CarModel);
            DB.Execute("sproc_tblCars_FilterByCarModel");
            PopulateArray(DB);
        }
        
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCarList = new List<clsCars>();
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
    }
}