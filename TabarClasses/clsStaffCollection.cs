using System;
using System.Collections.Generic;
using TabarClasses;

namespace TabarClasses
{
    public class clsStaffCollection
    {
        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();
        
        //Public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //Return the private data
                return mThisStaff;
            }
            set
            {
                //Set the private data
                mThisStaff = value;
            }
        }
        //Public property for count
        public int count
        {
            get
            {
                //Return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //We shall worry about this later
            }
        }

        //Constructor for the class
        public clsStaffCollection()
        {
            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount = 0;
            //Object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            //DB.Execute( = DB.Count;
            //Get the count of the record
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank staff
                clsStaff AnStaff = new clsStaff();
                //Read in the fields from the current record
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AnStaff.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AnStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnStaff.TelephoneNo = Convert.ToString(DB.DataTable.Rows[Index]["TelephoneNo"]);
                AnStaff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                //Add the record to the private data member
                mStaffList.Add(AnStaff);
                //Point at the next record
                Index++;
            }
        }
         

      
  
   


        public int Count { get; set; }
       
        public List<clsStaff> StaffList { get; set; }

        public int Add()
        {
            //Adds new record to the database based on the values of mThisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@HouseNo", mThisStaff.HouseNo);
            DB.AddParameter("@Street", mThisStaff.Street);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@TelephoneNo", mThisStaff.TelephoneNo);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Manager", mThisStaff.Active);
            DB.AddParameter("@Department", mThisStaff.Department);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            //Deletes the record pointed to by thisStaff
            //connect the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //Update an existing record based on the values of thisStaff
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@Surname", mThisStaff.Surname);
            DB.AddParameter("@HouseNo", mThisStaff.HouseNo);
            DB.AddParameter("@Street", mThisStaff.Street);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@TelephoneNo", mThisStaff.TelephoneNo);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}