using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TabarClasses;

public partial class StaffEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Update()
    {
        //Update and existing record based on the values of ThisStaff
        //Connect to the database
        clsDataConnection DB = new clsDataConnection();
        //Set the parameter for the stored procedure
        DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
        DB.AddParameter("@FirstName", mThisStaff.FirstName);
        DB.AddParameter("@Surname", mThisStaff.Surname);
        DB.AddParameter("@HouseNo", mThisStaff.HouseNo);
        DB.AddParameter("@Street", mThisStaff.Street);
        DB.AddParameter("@PostCode", mThisStaff.PostCode);
        DB.AddParameter("@TelephoneNo", mThisStaff.TelephoneNo);
        DB.AddParameter("@DOB", mThisStaff.DOB);
        DB.AddParameter("@Active", mThisStaff.Active);
        //Execute the stored procedure
        DB.Execute("sproc_tblStaff_Update");
    }
}