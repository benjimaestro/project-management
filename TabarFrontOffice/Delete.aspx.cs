using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class Delete : System.Web.UI.Page
{
    Int32 CustomerNo;
    string RedirectURL;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.Find(CustomerNo);
        lblDelete.Text = "Are you sure you want to delete account " + Customers.ThisCustomer.EMail;
        if (Convert.ToString(Session["Mode"]) == "StaffView") { RedirectURL = "Default.aspx"; }
        else { RedirectURL = "CustomerMenu.aspx"; }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect(RedirectURL);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        if (Convert.ToString(Session["Mode"]) == "CustomerView") { RedirectURL = "Login.aspx"; }
        CustomerList.Delete(CustomerNo);
        Response.Redirect(RedirectURL);
    }
}