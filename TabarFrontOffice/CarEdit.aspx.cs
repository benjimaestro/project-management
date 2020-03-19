using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses; 

public partial class CarEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCars ACar = new clsCars();
        ACar = (clsCars)Session["ACar"];
        Response.Write(ACar.CarMake);
        Response.Write(ACar.CarModel);
        Response.Write(ACar.CarModelNumber);
        Response.Write(ACar.CarColour);
        Response.Write(ACar.CarPrice);
        Response.Write(ACar.CarTypeNumber);
        Response.Write(ACar.CarReleaseDate);
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

    }
}