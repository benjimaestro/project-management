using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses; 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      if (IsPostBack == false)
        {
            DisplayCars(); 
        }
    }
    void DisplayCars()
    {
        TabarClasses.clsCarsCollection Cars = new TabarClasses.clsCarsCollection();
        lstCarList.DataSource = Cars.CarList;
        lstCarList.DataValueField = "CarNo";
        lstCarList.DataTextField = "CarMake";
        //lstCarList.DataTextField = "CarModel";
        lstCarList.DataBind();
    }

    protected void btnApplyCarColour_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CarNo"] = -1; 
        Response.Redirect("CarAdd.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarEdit.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarDelete.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {

    }
}