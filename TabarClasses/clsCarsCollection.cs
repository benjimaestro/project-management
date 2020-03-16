using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text; 
namespace TabarClasses
{
    public class clsCarsCollection
    {
        public clsCarsCollection()
        {

        }

        public Boolean Delete(Int32 CarNo) 
        {
            try
            {
                clsDataConnection MyDatabase = new clsDataConnection();
                MyDatabase.AddParameter("@CarNo", CarNo);
                MyDatabase.Execute("sproc_tblCars_Delete");
                return true; 
            }
            catch
            {
                return false; 
            }
        }
    }
}