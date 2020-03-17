using System;
using TabarClasses;


public partial class StaffManagement : System.Web.UI.Page
{
    private object txtName;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Event handler for the submit button
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //Add the new record
        Add();
        //All done so redirect back to main page
        Response.Redirect("StaffDefault.aspx");

        //Create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //Capture the first name
        AnStaff.FirstName =
        //Store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");


        //Capture the surname
        AnStaff.Surname = txtSurname.Text;
        //Store the staff in session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");


        //Capture the HouseNo
        AnStaff.Houseno = txthouseNo.Text;
        //Store the staff in session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");

        //Capture the street name
        AnStaff.Street = txtSreetName.Text;
        //Store the staff in session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");

        //Capture the postcode
        AnStaff.Postcode = txtPostcode.Text;
        //Store the staff in session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");

        //Capture the Telephone
        AnStaff.telephone = txtTelephone.Text;
        //Store the staff in session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");

        //Capture the DOB
        AnStaff.DOB = txtDOB.Text;
        //Store the staff in session object
        Session["AnStaff"] = AnStaff;
        //Redirect to the viewer page
        Response.Write("StaffViewer.aspx");

    }


    //Function for adding new records
    void Add()
    {
        //Create an instance of the address book
        TabarClasses.clsStaffCollection StaffCollection = new TabarClasses.clsStaffCollection();
        //Validate the data on the webform
        String Error = StaffCollection.ThisStaff.Valid(txtName.Text, txtSurname.Text, txtHouseNo.Text, txtStreet.Text, txtPostcode.Text, txtTelephoneNo.Text, txtActive.Text, txtDepartment.Text);
        //If the datais ok then add it to the object
        if (Error == "")
        {
            //Get the data entered by the user
            StaffCollection.ThisStaff.FirstName = txtName.Text;
            StaffCollection.ThisStaff.Surname = txtSurname.Text;
            StaffCollection.ThisStaff.HouseNo = txtHouseNo.Text;
            StaffCollection.ThisStaff.Street = txtStreet.Text;
            StaffCollection.ThisStaff.PostCode = txtPostCode.Text;
            StaffCollection.ThisStaff.TelephoneNo = txtTelephoneNo.Text;
            StaffCollection.ThisStaff.DOB = txtDOB.Text;
            StaffCollection.ThisStaff.Active = chkActive.Checked;
            //Add the record
            StaffCollection.Add();
        }
        else
        {
            //Report an error
            lblError.Text = "There was a problem with the data entered" + Error;
        }
    }

}


