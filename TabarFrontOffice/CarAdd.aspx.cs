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
        Add();
        Response.Redirect("Default.aspx");
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
    void Add()
    {
        clsCarsCollection CarShop = new clsCarsCollection();
        String Error = CarShop.ThisCar.Valid(txtCarMake.Text, txtCarModel.Text, txtCarModelNumber.Text, txtCarColour.Text, txtCarRDate.Text, Convert.ToInt32(txtCarPrice.Text));

        if (Error == "")
        {
            CarShop.ThisCar.CarMake = txtCarMake.Text;
            CarShop.ThisCar.CarModel = txtCarModel.Text;
            CarShop.ThisCar.CarModelNumber = txtCarModelNumber.Text;
            CarShop.ThisCar.CarColour = txtCarColour.Text;
            CarShop.ThisCar.CarReleaseDate = txtCarRDate.Text;
            CarShop.ThisCar.CarPrice = Convert.ToInt32(txtCarPrice.Text);
            CarShop.ThisCar.CarTypeNumber = Convert.ToInt32(drpCarType.SelectedValue);
            CarShop.Add();
          
        }
        else
        {
            lblError.Text = "There were problem with the data entered " + Error;
        }

    }
  
}