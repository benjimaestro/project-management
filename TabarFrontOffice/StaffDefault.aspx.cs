using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class _Default : System.Web.UI.Page
{
    //This function handles the laod event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayStaff();
        }
    }
    void DisplayStaff()
    {
        //Create an instance of the staff collection
        TabarClasses.clsStaffCollection Staff = new TabarClasses.clsStaffCollection();
        //Set the data source to the list of staff in the collection
        lstStaff.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaff.DataValueField = "StaffNo";
        //Set the data field to display
        lstStaff.DataTextField = "FirstName";
        //Bind the data to the list
        lstStaff.DataBind();

    }
    //Event handler for add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session object to indicate this is a new record
        Session["StaffNo"] = -1;
        //Redirect to the data entry page
        Response.Redirect("StaffManagement.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        //If a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //Get the primary key value of the record to delete
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            //Store the data in the session object
            Session["StaffNo"] = StaffNo;
            //Redirect to the delete page
            Response.Redirect("StaffDelete.aspx");
        }
        else //If no record has been selected
        {
            //Display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Var to store the primary key value of the record to be editied
        Int32 StaffNo;
        //If a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //Get the primary key for the edit record
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            //Store the data in the session object
            Session["StaffNo"] = StaffNo;
            //Redirect to the edit page
            Response.Redirect("StaffEdit.aspx");
        }
        else //If no record has been selected
        {
            //Display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}
    
        
    
  

    