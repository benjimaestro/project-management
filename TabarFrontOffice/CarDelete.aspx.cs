using System
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //this function handles the click event of the Yes Button 
        //create an instance of the  class clsCars called MyCars
        
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}