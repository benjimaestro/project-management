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

    protected void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
    {

    }

    void add()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        String Error = Customers.ThisCustomer.Valid(txtHouseNo.Text, txtHouseCounty.Text, txtPostcode.Text, txtHouseStreet.Text, txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text);
        if (Error == "")
        {
            Customers.ThisCustomer.HouseNo = Convert.ToInt32(txtHouseNo.Text);
            Customers.ThisCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            Customers.ThisCustomer.FirstName = txtFirstName.Text;
            Customers.ThisCustomer.LastName = txtLastName.Text;
            Customers.ThisCustomer.PostCode = txtPostcode.Text;
            Customers.ThisCustomer.HouseCounty = txtHouseCounty.Text;
            Customers.ThisCustomer.HouseStreet = txtHouseStreet.Text;
            Customers.ThisCustomer.EMail = txtEmail.Text;
            ///////////PASSWORD/////////////////////
            Customers.Add();
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        add();
        Response.Redirect("Default.aspx");
    }
}