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
        string Filter = txtFilterCarMake.Text;
        clsCarsCollection Cars = new clsCarsCollection();
        Cars.ReportByCarColour(Filter);
        lstCarList.Items.Clear();
        lstCarList.DataSource = Cars.CarList;
        lstCarList.DataValueField = "CarNo";
        lstCarList.DataTextField = "CarMake";
        lstCarList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CarNo"] = -1; 
        Response.Redirect("CarAdd.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CarNo; 
        if (lstCarList.SelectedIndex != -1)
        {
            CarNo = Convert.ToInt32(lstCarList.SelectedValue);
            Session["CarNo"] = CarNo;
            Response.Redirect("CarEdit.aspx"); 
        }
        else
        {
            lblError.Text = "Please select a record to edit ";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CarNo;
        if (lstCarList.SelectedIndex != 1)
        {
            try
            {
                CarNo = Convert.ToInt32(lstCarList.SelectedValue);
                Session["CarNo"] = CarNo;
                Response.Redirect("CarDelete.aspx");
            }
            catch
            {
                lblError.Text = "Please select a record you wish to delete frist ";
            }
        }
        else
        {
            lblError.Text = "Please select a record you wish to delete frist ";
        }
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void btnApplyCarMake_Click(object sender, EventArgs e)
    {
        string Filter = txtFilterCarMake.Text;
        clsCarsCollection Cars = new clsCarsCollection();
        Cars.ReportByCarMake(Filter);
        lstCarList.Items.Clear();
        lstCarList.DataSource = Cars.CarList;
        lstCarList.DataValueField = "CarNo";
        lstCarList.DataTextField = "CarMake";
        lstCarList.DataBind();
    }

    protected void btnApplyCarModel_Click(object sender, EventArgs e)
    {
        string Filter = txtFilterCarMake.Text;
        clsCarsCollection Cars = new clsCarsCollection();
        Cars.ReportByCarModel(Filter);
        lstCarList.Items.Clear();
        lstCarList.DataSource = Cars.CarList;
        lstCarList.DataValueField = "CarNo";
        lstCarList.DataTextField = "CarMake";
        lstCarList.DataBind();
    }

    protected void btnFilterCarPrice_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayCars(); 
    }


    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMenu.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order.aspx");
    }
}