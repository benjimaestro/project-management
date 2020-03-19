using System;
using System.Linq;
using System.Text; 
using System.Collections.Generic;

namespace TabarClasses
{
    public class clsCarTypeCollection
    {
        public clsCarTypeCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCarType_SelectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0; 
            while (Index < RecordCount)
            {
                clsCarType ACarType = new clsCarType();
                ACarType.CarType = DB.DataTable.Rows[Index]["CarType"].ToString();
                ACarType.CarTypeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CarTypeNo"]);
                mAllCarTypes.Add(ACarType);
                Index++; 
            }
        }
        private List<clsCarType> mAllCarTypes = new List<clsCarType>(); 
        public int Count 
        {
            get
            {
                return mAllCarTypes.Count; 
            }
            set
            {

            }
        }
        public List<clsCarType> AllCarTypes 
        {
            get
            {
                return mAllCarTypes; 
            }
            set
            {
                mAllCarTypes = value; 
            }
        }
    }
}