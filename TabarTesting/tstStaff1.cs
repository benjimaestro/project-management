using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstStaff1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]


        public void ManagerPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            AnStaff.Active = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnStaff.DOB = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.DOB, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "LE2 7DS";
            //Assign the data to the property
            AnStaff.PostCode = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "Some Street";
            //Asssign the data to the property
            AnStaff.Street = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Street, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "John";
            //Assign the data to the property
            AnStaff.FirstName = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }
        [TestMethod]
        public void SurnamePropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "Smith";
            //Assign the data to the property
            AnStaff.Surname = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Surname, TestData);
        }
        [TestMethod]
        public void TelphoneNoPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "07890345756";
            //Assign the data to the property
            AnStaff.TelephoneNo = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.TelephoneNo, TestData);
        }
        [TestMethod]
        public void StaffNoPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnStaff.StaffNo = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffNo, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnStaff.HouseNo = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.HouseNo, TestData);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want tot create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of the test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Active = true;
            TestItem.StaffNo = 1;
            TestItem.FirstName = "Tom";
            TestItem.Surname = "Campbell";
            TestItem.Street = "Some Street";
            TestItem.PostCode = "LE4 Q98";
            TestItem.TelephoneNo = "0123445";
            TestItem.DOB = "09/02/2000";
            //Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the two values are the same
        }

    }
}


