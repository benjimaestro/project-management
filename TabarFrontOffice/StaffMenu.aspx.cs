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
        //Runs when the page is loaded, calls DisplayCustomers()
        if (IsPostBack == false)
        { DisplayCustomers(); }
    }

    void DisplayCustomers()
    {
        //Gets list of customers and populates listbox with emails
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomers.Items.Clear();
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerNo";
        lstCustomers.DataTextField = "EMail";
        lstCustomers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Runs when the add button is pressed, opens Customer.aspx to add a new customer's details
        Session["CustomerNo"] = -1;
        Session["Mode"] = "StaffView";
        Response.Redirect("Customer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Runs when Delete is pressed, makes sure a selection is made and redirects to CustomerDelete.aspx with the customer number as a session object
        Int32 CustomerNo;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Session["Mode"] = "StaffView";
            Response.Redirect("CustomerDelete.aspx");
        }
        else { lblError.Text = "Select a customer to delete"; }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Runs when Delete is pressed, makes sure a selection is made and redirects to Customer.aspx with the customer number as a session object
        //so that the page knows to edit details rather than add a new customer
        Int32 CustomerNo;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerNo"] = CustomerNo;
            Session["Mode"] = "StaffView";
            Response.Redirect("Customer.aspx");
        }
        else { lblError.Text = "Select a customer to edit"; }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        //Runs when Search is pressed, searches customers for emails that match search critera and populates listbox with these customers
        string Search = txtFilter.Text;
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByEMail(Search);
        lstCustomers.Items.Clear();
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerNo";
        lstCustomers.DataTextField = "EMail";
        lstCustomers.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //Runs when Show All is pressed, populates listbox with all customers
        DisplayCustomers();
    }

    protected void txtFilter_TextChanged(object sender, EventArgs e)
    {

    }
}