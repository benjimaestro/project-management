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

 
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCars ACar = new clsCars();
        ACar.CarMake = txtCarMake.Text;
        Session["ACar"] = ACar;
        Response.Redirect("Default.aspx");
    }

    protected void txtCarRDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}