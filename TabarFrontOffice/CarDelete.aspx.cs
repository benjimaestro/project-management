using System;
using TabarClasses;
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
        //copy the data from the interface to the RAM converting the data to INT32 
        //invoke the delete method of the object passing it the data entered by the user 
        clsCarsCollection MyCars = new clsCarsCollection();
        Int32 CarNo;
        Boolean Success; 
        CarNo = Convert.ToInt32(txtCarNo.Text);
        Success = MyCars.Delete(CarNo); 
        if (Success == true)
        {
            lblError.Text = "You deleted car number " + CarNo; 
        }
        else
        {
            lblError.Text = "There weas a problem when trying to delete"; 
        }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}