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
        //Runs when the page is loaded, checks session object for CustomerNo. If it's not -1, it fills the controls with the customer's details
        //for editing. Otherwise it runs empty.
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
                txtPhoneNo.Text = Convert.ToString(Customers.ThisCustomer.PhoneNo);
                txtFirstName.Text = Customers.ThisCustomer.FirstName;
                txtLastName.Text = Customers.ThisCustomer.LastName;
                txtPostcode.Text = Customers.ThisCustomer.PostCode;
                txtHouseCounty.Text = Customers.ThisCustomer.HouseCounty;
                txtHouseStreet.Text = Customers.ThisCustomer.HouseStreet;
                txtEmail.Text = Customers.ThisCustomer.EMail;
            }
        }
        else { lblTitle.Text = "Register"; }

        //These are used for redirecting back to the correct page when either cancel or save are pressed, as staff and customers do not see the same pages
        if (Mode == "StaffView") { RedirectURL = "Default.aspx"; }
        if (Mode == "CustomerView") { RedirectURL = "CustomerMenu.aspx"; }
        if (Mode == "GuestView") { RedirectURL = "Login.aspx"; }
        //if (IsPostBack == false) {  }
    }

    protected void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
    {

    }

    string add()
    {
        //function to take details from form to validate and then add them to the clsCustomer class so they can be added to the DB
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
        //function to take details from form to validate and then update the customer they belong to in clsCustomer so it can be changed in the DB
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
        //Runs when Save is clicked. Behaviour depends on if the user's intention was to register or edit existing details
        //Redirects depend on if the user originated from Default.aspx, CustomerMenu.aspx, or Login.aspx
        if (CustomerNo == -1)
        {
            string Error = add();
            if (Error == "") 
            {
                if (Error == "")
                {
                    if (RedirectURL != "Default.aspx")
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
        //Runs when Cancel is clicked.
        //Redirects depend on if the user originated from Default.aspx, CustomerMenu.aspx, or Login.aspx
        Response.Redirect(RedirectURL);
    }
}