using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //No logic on page load required
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Runs when login is clicked
        //Uses hash function in clsCustomerCollection for security
        //Searches for email and if found it compares password hash
        //If it's a match then customer is redirected to CustomerMenu.aspx with the customer number
        //Otherwise an error is displayed if EMail isn't found or password is wrong
        clsCustomerCollection Customers = new clsCustomerCollection();
        string EMail = txtEMail.Text;
        string Password = Customers.GetHashPassword(txtPassword.Text);
        Customers.FindEMail(EMail);
        if (Password == Customers.ThisCustomer.Password)
        {
            Session["CustomerNo"] = Customers.ThisCustomer.CustomerNo;
            Response.Redirect("CustomerMenu.aspx");
        }
        else
        {
            if (Password != Customers.ThisCustomer.Password)
            {
                lblLoginError.Text = "Incorrect details";
            }
            if (Customers.ThisCustomer.EMail == null)
            {
                lblLoginError.Text = "EMail not found";
            }
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //Redirects to Customer.aspx with the -1 CustomerNo so the page knows to add rather than update
        //Redirects to Customer.aspx with the GuestView Mode so the page knows where to redirect to if cancel is pressed on Customer.aspx
        Session["Mode"] = "GuestView";
        Session["CustomerNo"] = -1;
        Response.Redirect("Customer.aspx");
    }
}