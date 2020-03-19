using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses; 

public partial class CarDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCarsCollection MyCarShop = new clsCarsCollection();
        Int32 CarNo;
        Boolean Success;
        CarNo = Convert.ToInt32(txtCarNo.Text);
        Success = MyCarShop.Delete(CarNo); 
        if (Success == true)
        {
            lblError.Text = "You have deleted car number " + CarNo;
        }
        else
        {
            lblError.Text = "There was an error which prevented the process of deleting the record ";
        }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}