using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class CustomerMenu : System.Web.UI.Page
{
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Runs when page is loaded
        //Sets CustomerNo from session object and displays user's saved name at the top
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.Find(CustomerNo);
        lblTitle.Text = "Hello " + Customers.ThisCustomer.FirstName + " " + Customers.ThisCustomer.LastName;
        Session["CustomerNo"] = Customers.ThisCustomer.CustomerNo;
        Session["Mode"] = "CustomerView";
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Redirects the user to Customer.aspx to edit their details
        Response.Redirect("Customer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Redirects the user to Delete.aspx to delete their account
        Response.Redirect("Delete.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //Redirects the user to Login.aspx and clears their ID from the session object
        Session["CustomerNo"] = -1;
        Session["Mode"] = "GuestView";
        Response.Redirect("Login.aspx");
    }
}