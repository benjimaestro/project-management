using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;


public partial class Login : System.Web.UI.Page
{
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (CustomerNo != -1)
        {
            if (IsPostBack == false)
            {
                lblTitle.Text = "Change account details";
                clsCustomerCollection Customers = new clsCustomerCollection();
                Customers.Find(CustomerNo);
                txtHouseNo.Text = Convert.ToString(Customers.ThisCustomer.HouseNo);
                txtPhoneNo.Text = Convert.ToString(Customers.ThisCustomer.PhoneNo);
                txtFirstName.Text = Customers.ThisCustomer.FirstName;
                txtLastName.Text = Customers.ThisCustomer.LastName;
                txtPostcode.Text = Customers.ThisCustomer.PostCode;
                txtHouseCounty.Text = Customers.ThisCustomer.HouseCounty;
                txtHouseStreet.Text = Customers.ThisCustomer.HouseStreet;
                txtEmail.Text = Customers.ThisCustomer.EMail;
                lblError.Text = Convert.ToString(CustomerNo);
            }
        }
        else { lblTitle.Text = "Register"; }
        //if (IsPostBack == false) {  }
    }

    protected void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
    {

    }

    string add()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        String Error = Customers.ThisCustomer.Valid(txtHouseNo.Text, txtHouseCounty.Text, txtPostcode.Text, txtHouseStreet.Text, txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtPassword.Text, txtPasswordConfirm.Text);
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
            Customers.ThisCustomer.Password = Customers.GetHashPassword(txtPassword.Text);//Hash password before adding
            Customers.Add();
            return Error;
        }
        else
        {
            lblError.Text = Error;//Display errors
            return Error;
        }
    }

    string update()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        String Error = Customers.ThisCustomer.Valid(txtHouseNo.Text, txtHouseCounty.Text, txtPostcode.Text, txtHouseStreet.Text, txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtPassword.Text, txtPasswordConfirm.Text);
        if (Error == "")
        {
            Customers.Find(CustomerNo);
            Customers.ThisCustomer.HouseNo = Convert.ToInt32(txtHouseNo.Text);
            Customers.ThisCustomer.PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            Customers.ThisCustomer.FirstName = txtFirstName.Text;
            Customers.ThisCustomer.LastName = txtLastName.Text;
            Customers.ThisCustomer.PostCode = txtPostcode.Text;
            Customers.ThisCustomer.HouseCounty = txtHouseCounty.Text;
            Customers.ThisCustomer.HouseStreet = txtHouseStreet.Text;
            Customers.ThisCustomer.EMail = txtEmail.Text;
            Customers.ThisCustomer.Password = Customers.GetHashPassword(txtPassword.Text);//Hash password before adding
            Customers.Update();
            Response.Redirect("Default.aspx");
            return Error;
        }
        else
        {
            lblError.Text = Error;//Display errors
            return Error;
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (CustomerNo == -1)
        {
            string Error = add();
            if (Error == "") { Response.Redirect("Default.aspx"); }
        }
        else
        {
            string Error = update();
            if (Error == "") { Response.Redirect("Default.aspx"); }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}