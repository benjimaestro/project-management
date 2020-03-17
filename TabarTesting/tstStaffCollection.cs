using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;
using System.Collections.Generic;
namespace TabarClasses { }


    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllStaff);

        }
        public void StaffListOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign a new property
            //In this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //Create the item to test data
            clsStaff TestItem = new clsStaff();
            //Set the properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Tom";
            TestItem.Surname = "Campbell";
            TestItem.Street = "Some street";
            TestItem.PostCode = "LE4 09E";
            TestItem.TelephoneNo = "0123445";
            TestItem.DOB = "09/02/1998";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //Set properties of the test object
            TestStaff.Active = true;
            TestStaff.StaffNo = 1;
            TestStaff.FirstName = "Tom";
            TestStaff.Surname = "Campbell";
            TestStaff.Street = "Some street";
            TestStaff.PostCode = "LE4 09E";
            TestStaff.TelephoneNo = "0123445";
            TestStaff.DOB = "09/02/1998";
            //Assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //Test to see that two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //Create the itm of test data
            clsStaff TestItem = new clsStaff();
            //Set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Tom";
            TestItem.Surname = "Campbell";
            TestItem.Street = "Some Street";
            TestItem.PostCode = "LE4 09E";
            TestItem.TelephoneNo = "0123445";
            TestItem.DOB = "09/02/1998";
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create an item of the test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Tom";
            TestItem.Surname = "Campbell";
            TestItem.Street = "Some Street";
            TestItem.PostCode = "LE3 56T";
            TestItem.TelephoneNo = "0192934";
            TestItem.DOB = "02/12/1989";
            //Set ThisSatff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.Add();
            //Set the primary key for the test data
            TestItem.StaffNo = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Delete the record
            AllStaff.Delete();
            //Now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the record was not found
            Assert.IsFalse(Found);
                
        }

        [TestMethod]
        public void UpdateMethodOK()
    {
        //Create an instance of the class we want to create
        clsStaffCollection AllStaff = new clsStaffCollection();
        //Create the item of test data
        clsStaff TestItem = new clsStaff();
        //var to store the primary key
        Int32 PrimaryKey = 0;
        //Set the properties
        TestItem.Active = true;
        TestItem.StaffNo = 1;
        TestItem.FirstName = "Tom";
        TestItem.Surname = "Campbell";
        TestItem.Street = "Some Street";
        TestItem.PostCode = "LE3 56T";
        TestItem.TelephoneNo = "0192934";
        TestItem.DOB = "02/12/1989";
        //set the ThisStaff to the test data
        AllStaff.ThisStaff = TestItem;
        //Add the record
        PrimaryKey = AllStaff.Add();
        //Set the primary key of the test data
        TestItem.StaffNo = PrimaryKey;
        //Modify the test data
        TestItem.Active = false;
        TestItem.StaffNo = 2;
        TestItem.FirstName = "Teddy";
        TestItem.Surname = "Jones";
        TestItem.Street = "A Street";
        TestItem.PostCode = "L34 54T";
        TestItem.TelephoneNo = "019990000";
        TestItem.DOB = "04/10/1999";
        //Set the record based on new test data
        AllStaff.ThisStaff = TestItem;
        //Update the record
        AllStaff.Update();
        //Find the record
        AllStaff.ThisStaff.Find(PrimaryKey);
        //Test to see ThisStaff matches the test data
        Assert.AreEqual(AllStaff.ThisStaff, TestItem);


    }

    }

