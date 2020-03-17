using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //Get data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //Display the Staff first name for this entry
        Response.Write(AnStaff.FirstName);
    }
}