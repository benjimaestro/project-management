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
        public clsCars()
        {
        }

        public int CarNo { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarModelNumber { get; set; }
        public int CarPrice { get; set; }
        public string CarReleaseDate { get; set; }
        public string CarColour { get; set; }
        public int CarTypeNumber { get; set; }

        public void Find(int primaryKey)
        {
            clsCars SomeCar = new clsCars();
            SomeCar.Find(3); 
        }

        public string Valid(System.Web.UI.WebControls.TextBox txtCarMake, string text1, string text2, string text3, string text4, string text5)
        {
            return 
        }
    }
}