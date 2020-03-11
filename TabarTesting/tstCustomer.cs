using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 48;
            Found = Customer.Find(CustomerNo);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNotFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 48;
            Found = Customer.Find(CustomerNo);
            if (Customer.CustomerNo != 48)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InstanceOK()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Int32 TestData = 1;
                
            Customer.CustomerNo = TestData;
                
            Assert.AreEqual(Customer.CustomerNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
                
            clsCustomer ACustomer = new clsCustomer();
                
            Int32 TestData = 1;
                
            ACustomer.HouseNo = TestData;
                
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void HouseCountyPropertyOK()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            string TestData = "Leicestershire";
                
            Customer.HouseCounty = TestData;
                
            Assert.AreEqual(Customer.HouseCounty, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            string TestData = "LE1 4AB";
                
            Customer.PostCode = TestData;
                
            Assert.AreEqual(Customer.PostCode, TestData);
        }

        [TestMethod]
        public void HouseStreetPropertyOK()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            string TestData = "Main Street";
                
            Customer.HouseStreet = TestData;
                
            Assert.AreEqual(Customer.HouseStreet, TestData);
        }

        [TestMethod]
        public void EMailPropertyOK()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            string TestData = "TestEmail@gmail.com";
                
            Customer.EMail = TestData;
                
            Assert.AreEqual(Customer.EMail, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {

            clsCustomer Customer = new clsCustomer();

            string TestData = "First";

            Customer.FirstName = TestData;

            Assert.AreEqual(Customer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {

            clsCustomer Customer = new clsCustomer();

            string TestData = "Last";

            Customer.LastName = TestData;

            Assert.AreEqual(Customer.LastName, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {

            clsCustomer Customer = new clsCustomer();

            string TestData = "12345678";

            Customer.PhoneNo = TestData;

            Assert.AreEqual(Customer.PhoneNo, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {

            clsCustomer Customer = new clsCustomer();

            string TestData = "qwertyuiop";

            Customer.Password = TestData;

            Assert.AreEqual(Customer.Password, TestData);
        }

        [TestMethod]
        public void TestHouseNoFound()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Boolean Found = false;
                
            Boolean OK = true;
                
            Int32 CustomerNo = 48;
                
            Found = Customer.Find(CustomerNo);
                
            if (Customer.HouseNo != 999)
            {
                OK = false;
            }
                
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseCountyFound()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Boolean Found = false;
                
            Boolean OK = true;
                
            Int32 CustomerNo = 48;
                
            Found = Customer.Find(CustomerNo);
                
            if (Customer.HouseCounty != "TESTDATA")
            {
                OK = false;
            }
                
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Boolean Found = false;
                
            Boolean OK = true;
                
            Int32 CustomerNo = 48;
                
            Found = Customer.Find(CustomerNo);
                
            if (Customer.PostCode != "TEST1")
            {
                OK = false;
            }
                
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseStreetFound()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Boolean Found = false;
                
            Boolean OK = true;
                
            Int32 CustomerNo = 48;
                
            Found = Customer.Find(CustomerNo);
                
            if (Customer.HouseStreet != "TESTDATA")
            {
                OK = false;
            }
                
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEMailFound()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Boolean Found = false;
                
            Boolean OK = true;
                
            Int32 CustomerNo = 48;
                
            Found = Customer.Find(CustomerNo);
                
            if (Customer.EMail != "TESTDATA@TESTDATA.com")
            {
                OK = false;
            }
                
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
                
            clsCustomer Customer = new clsCustomer();
                
            Boolean Found = false;
                
            Boolean OK = true;
            Int32 CustomerNo = 48;
                
            Found = Customer.Find(CustomerNo);
            if (Customer.FirstName != "TESTDATA")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {

            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;
            Int32 CustomerNo = 48;

            Found = Customer.Find(CustomerNo);
            if (Customer.LastName != "TESTDATA")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNoFound()
        {

            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;
            Int32 CustomerNo = 48;

            Found = Customer.Find(CustomerNo);
            if (Customer.PhoneNo != "99999999")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestPasswordFound()
        {

            clsCustomer Customer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;
            Int32 CustomerNo = 48;

            Found = Customer.Find(CustomerNo);
            if (Customer.Password != "TESTDATA")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
