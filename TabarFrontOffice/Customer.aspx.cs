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
    string Mode;
    string RedirectURL;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Called upon page load
        //Sets customer number to whatever was passed in the session object, as well as a session object that depends on which page the user originated from
        //so that they can be redirected to the correct page
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        Mode = Convert.ToString(Session["Mode"]);
        if (CustomerNo != -1)
        {
            if (IsPostBack == false)
            {
                lblTitle.Text = "Change account details";
                clsCustomerCollection Customers = new clsCustomerCollection();
                Customers.Find(CustomerNo);
                txtHouseNo.Text = Convert.ToString(Customers.ThisCustomer.HouseNo);
                txtPhoneNo.Text = Customers.ThisCustomer.PhoneNo;
                txtFirstName.Text = Customers.ThisCustomer.FirstName;
                txtLastName.Text = Customers.ThisCustomer.LastName;
                txtPostcode.Text = Customers.ThisCustomer.PostCode;
                txtHouseCounty.Text = Customers.ThisCustomer.HouseCounty;
                txtHouseStreet.Text = Customers.ThisCustomer.HouseStreet;
                txtEmail.Text = Customers.ThisCustomer.EMail;
            }
        }
        else { lblTitle.Text = "Register"; }
        if (Mode == "StaffView") { RedirectURL = "StaffMenu.aspx"; }
        if (Mode == "CustomerView") { RedirectURL = "CustomerMenu.aspx"; }
        if (Mode == "GuestView") { RedirectURL = "Login.aspx"; }
        //if (IsPostBack == false) {  }
    }

    string add()
    {
        //Function to add a customer to the clsCustomerCollection list and then call a function to add it to the DB
        //If it fails, an error is displayed
        String Error = "";
        clsCustomerCollection PreCustomers = new clsCustomerCollection();
        PreCustomers.FindEMail(txtEmail.Text);
        if (PreCustomers.ThisCustomer.EMail != null)
        {
            Error = Error + "EMail already in use </br>";
        }
        clsCustomerCollection Customers = new clsCustomerCollection();

        Error = Error + Customers.ThisCustomer.Valid(txtHouseNo.Text, txtHouseCounty.Text, txtPostcode.Text, txtHouseStreet.Text, txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtPassword.Text, txtPasswordConfirm.Text);
        if (Error == "")
        {
            Customers.ThisCustomer.HouseNo = Convert.ToInt32(txtHouseNo.Text);
            Customers.ThisCustomer.PhoneNo = txtPhoneNo.Text;
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
        //Function to add a customer to the clsCustomerCollection list and then call a function to modify that customer's existing details in the DB
        //If it fails, an error is displayed
        String Error = "";
        clsCustomerCollection PreCustomers = new clsCustomerCollection();
        clsCustomerCollection Customers = new clsCustomerCollection();
        PreCustomers.FindEMail(txtEmail.Text);
        Customers.Find(CustomerNo);
        if (PreCustomers.ThisCustomer.EMail != null && PreCustomers.ThisCustomer.EMail != Customers.ThisCustomer.EMail)
        {
            Error = Error + "EMail already in use </br>";
        }

        Error = Error + Customers.ThisCustomer.Valid(txtHouseNo.Text, txtHouseCounty.Text, txtPostcode.Text, txtHouseStreet.Text, txtEmail.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNo.Text, txtPassword.Text, txtPasswordConfirm.Text); if (Error == "")
        {
            Customers.Find(CustomerNo);
            Customers.ThisCustomer.HouseNo = Convert.ToInt32(txtHouseNo.Text);
            Customers.ThisCustomer.PhoneNo = txtPhoneNo.Text;
            Customers.ThisCustomer.FirstName = txtFirstName.Text;
            Customers.ThisCustomer.LastName = txtLastName.Text;
            Customers.ThisCustomer.PostCode = txtPostcode.Text;
            Customers.ThisCustomer.HouseCounty = txtHouseCounty.Text;
            Customers.ThisCustomer.HouseStreet = txtHouseStreet.Text;
            Customers.ThisCustomer.EMail = txtEmail.Text;
            Customers.ThisCustomer.Password = Customers.GetHashPassword(txtPassword.Text);//Hash password before adding
            Customers.Update();
            Session["CustomerNo"] = Customers.ThisCustomer.CustomerNo;
            Response.Redirect(RedirectURL);
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
        //Called when save button is pressed, runs add/update function depending on what the user pressed to get to this page
        //Redirects back to whereever the user originated from
        if (CustomerNo == -1)
        {
            string Error = add();
            if (Error == "") 
            {
                if (Error == "")
                {
                    if (RedirectURL != "StaffMenu.aspx")
                    {
                        RedirectURL = "Login.aspx";
                    }
                    Response.Redirect(RedirectURL);
                }
            }
        }
        else
        {
            string Error = update();
            if (Error == "")
            {
                if (RedirectURL == "Login.aspx")
                {
                    RedirectURL = "CustomerMenu.aspx";
                }
                Response.Redirect(RedirectURL);
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Redirects to wherever the user originated from
        Response.Redirect(RedirectURL);
    }
}