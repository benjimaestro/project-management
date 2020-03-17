using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class StaffDelete : System.Web.UI.Page
{
    //Var to store the primary key of the record delete
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the staff to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    public void Delete()
    {
        //Deletes the record pointed to by thisStaff
        //Connect the database
        clsDataConnection DB = new clsDataConnection();
        //Set the parameter for the stored procedure
        DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
        //Execute the stored procedure
        DB.Execute("sproc_tblStaff_Delete");
    }

    void DeleteStaff()
    {
        //Function to delete the selected record
        //Create a new instance of the staff collection
        clsStaffCollection staffCollection = new clsStaffCollection();
        //Find the record to delete
        staffCollection.ThisStaff.Find(StaffNo);
        //Deletes the record
        staffCollection.Delete();
    }

    //Event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Deltes the record
        DeleteStaff();
        //Redirect you to main page
        Response.Redirect("StaffDefault.aspx");
    }
}