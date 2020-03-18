using System;
using TabarClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        clsCar ACar = new clsCar();
        ACar.CarMake = txtCarMake.Text;
        ACar.CarModel = txtCarModel.Text;
        ACar.CarModelNumber = txtCarModelNumber.Text;
        //ACar.CarPrice = txtCarPrice.Text;
        ACar.CarColour = txtCarColour.Text;
        ACar.CarReleaseDate = txtCarRDate.Text;
        //ACar.CarTypeNumber = drpCarType.Text; 

        Session["ACar"] = ACar;
        Response.Redirect("Default.aspx");
    }
}