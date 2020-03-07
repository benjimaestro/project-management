using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        { DisplayCustomers(); }
    }

    void DisplayCustomers()
    {
        TabarClasses.clsCustomerCollection Customers = new TabarClasses.clsCustomerCollection();
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerNo";
        lstCustomers.DataTextField = "EMail";
        lstCustomers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerNo"] = -1;
        Response.Redirect("Customer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("Delete.aspx");
        }
        else { lblError.Text = "Select a customer to delete"; }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Response.Redirect("Customer.aspx");
        }
        else { lblError.Text = "Select a customer to edit"; }
    }
}