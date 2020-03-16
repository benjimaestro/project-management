using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}