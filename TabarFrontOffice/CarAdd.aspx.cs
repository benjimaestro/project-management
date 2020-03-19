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
        if (IsPostBack == false)
        {
            DisplayAllCarTypes(); 
        }
    }

 
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCars ACar = new clsCars();
        ACar.CarMake = txtCarMake.Text;
        ACar.CarModel = txtCarModel.Text;
        ACar.CarModelNumber = txtCarModelNumber.Text;
        ACar.CarColour = txtCarColour.Text;
        ACar.CarPrice = Convert.ToInt32(this.txtCarPrice.Text);
       // ACar.CarTypeNumber = Convert.ToInt32(this.drpCarType.Text);
        ACar.CarReleaseDate = txtCarRDate.Text;
        Session["ACar"] = ACar;
        Response.Redirect("CarEdit.aspx");
    }

    protected void txtCarRDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    void DisplayAllCarTypes()
    {
        clsCarTypeCollection CarTypes = new clsCarTypeCollection();
        drpCarType.DataSource = CarTypes.AllCarTypes;
        drpCarType.DataValueField = "CarTypeNo";
        drpCarType.DataTextField = "CarType";
        drpCarType.DataBind(); 
    }
  
}