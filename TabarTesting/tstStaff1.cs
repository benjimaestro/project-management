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
        public void HouseNoProperty()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "21";
            //Assign the data to the property
            AnStaff.HouseNo = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.HouseNo, TestData);
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
        public void TownPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Create some test data to assign to the property
            string TestData = "Leicester";
            //Assign the data to the property
            AnStaff.Town = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnStaff.Town, TestData);
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
    }
}

