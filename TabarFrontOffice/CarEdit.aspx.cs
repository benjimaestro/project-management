using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses; 

public partial class CarEdit : System.Web.UI.Page
{
    
    Int32 CarNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CarNo = Convert.ToInt32(Session["CarNo"]);
        if (IsPostBack == false)
        {
            DisplayAllCarTypes(); 
        }
        if (CarNo != -1)
        {
            DisplayCars(); 
        }
            
    }
    void DisplayAllCarTypes()
    {
        clsCarTypeCollection CarTypes = new clsCarTypeCollection();
        drpCarType.DataSource = CarTypes.AllCarTypes;
        drpCarType.DataValueField = "CarTypeNo";
        drpCarType.DataTextField = "CarType";
        drpCarType.DataBind();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (CarNo == -1)
        {
            Add(); 
        }
        else
        {
            Update(); 
        }
    }
    void Update()
    {
        clsCarsCollection CarShop = new clsCarsCollection();
        String Error = CarShop.ThisCar.Valid(txtCarMake.Text, txtCarModel.Text, txtCarModelNumber.Text, txtCarColour.Text, txtCarRDate.Text, Convert.ToInt32(txtCarPrice.Text));
        if (Error == "")
        {
            CarShop.ThisCar.Find(CarNo);
            CarShop.ThisCar.CarMake = txtCarMake.Text;
            CarShop.ThisCar.CarModel = txtCarModel.Text;
            CarShop.ThisCar.CarModelNumber = txtCarModelNumber.Text;
            CarShop.ThisCar.CarColour = txtCarColour.Text;
            CarShop.ThisCar.CarReleaseDate = txtCarRDate.Text;
            CarShop.ThisCar.CarPrice = Convert.ToInt32(txtCarPrice.Text);
            CarShop.ThisCar.CarTypeNumber = Convert.ToInt32(drpCarType.SelectedValue);
            CarShop.Update();
            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There was a problem with he data entered" + Error;
        } 
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
    void DisplayCars()
    {
        clsCarsCollection CarShop = new clsCarsCollection();
        CarShop.ThisCar.Find(CarNo);
        txtCarMake.Text = CarShop.ThisCar.CarMake;
        txtCarModel.Text = CarShop.ThisCar.CarModel;
        txtCarModelNumber.Text = CarShop.ThisCar.CarModelNumber;
        txtCarPrice.Text = CarShop.ThisCar.CarPrice.ToString();
        txtCarColour.Text = CarShop.ThisCar.CarColour;
        txtCarRDate.Text = CarShop.ThisCar.CarReleaseDate;
        drpCarType.SelectedValue = CarShop.ThisCar.CarTypeNumber.ToString(); 
    }

}