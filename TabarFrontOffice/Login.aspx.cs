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

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        string EMail = txtEMail.Text;
        string Password = Customers.GetHashPassword(txtPassword.Text);
        Customers.FindEMail(EMail);
        if (Password == Customers.ThisCustomer.Password)
        {
            Session["CustomerNo"] = Customers.ThisCustomer.CustomerNo;
            Response.Redirect("CustomerMenu.aspx");
        }
        else { lblLoginError.Text="Incorrect details"; }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Session["Mode"] = "GuestView";
        Session["CustomerNo"] = -1;
        Response.Redirect("Customer.aspx");
    }
}