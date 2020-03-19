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
        //Runs when the page is loaded, checks session object for CustomerNo
        //If no CustomerNo provided, it will redirect to prevent crashes/incorrect deletion
        //Redirects when yes/no are pressed depend on where the user originated from (CustomerMenu.aspx, Default.aspx)
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        RedirectURL = Convert.ToString(Session["Mode"]);
        if (Session["CustomerNo"] == null) { Response.Redirect("Login.aspx"); }
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.Find(CustomerNo);
        lblDelete.Text = "Are you sure you want to delete account " + Customers.ThisCustomer.EMail;
        if (Convert.ToString(Session["Mode"]) == "StaffView") { RedirectURL = "StaffMenu.aspx"; }
        else { RedirectURL = "CustomerMenu.aspx"; }
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirects back to Default.aspx or CustomerMenu.aspx depending on where the user originated from
        Response.Redirect(RedirectURL);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Runs delete function in clsCustomerCollection to remove from customer list and remove from DB
        //Redirects back to Default.aspx or CustomerMenu.aspx depending on where the user originated from
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        if (Convert.ToString(Session["Mode"]) == "CustomerView") { RedirectURL = "Login.aspx"; }
        CustomerList.Delete(CustomerNo);
        Response.Redirect(RedirectURL);
    }
}