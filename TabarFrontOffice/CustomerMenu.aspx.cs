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
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.Find(CustomerNo);
        lblTitle.Text = "Hello " + Customers.ThisCustomer.FirstName + " " + Customers.ThisCustomer.LastName;
        Session["CustomerNo"] = Customers.ThisCustomer.CustomerNo;
        Session["Mode"] = "CustomerView";
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Customer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("Delete.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["CustomerNo"] = -1;
        Session["Mode"] = "GuestView";
        Response.Redirect("Login.aspx");
    }
}