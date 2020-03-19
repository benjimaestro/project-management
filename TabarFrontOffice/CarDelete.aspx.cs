using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses; 

public partial class CarDelete : System.Web.UI.Page
{
    clsCarsCollection CarShop = new clsCarsCollection();
    Int32 CarNo; 
    protected void Page_Load(object sender, EventArgs e)
    {
        CarNo = Convert.ToInt32(Session["CarNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {

        DeleteCars();
        Response.Redirect("Default.aspx");
    }
    void DeleteCars()
    {
        clsCarsCollection CarShop = new clsCarsCollection();
        CarShop.ThisCar.Find(CarNo);
        CarShop.Delete();
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}