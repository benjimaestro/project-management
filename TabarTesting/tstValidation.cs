using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstValidation
    {
        [TestMethod]
        public void InstanceOKValidate()
        {
            clsValidate Validator = new clsValidate();
            Assert.IsNotNull(Validator);
        }
        [TestMethod]
        public void InstanceOKCustomer()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void ValidatePhone()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone(12345678);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmail()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("h@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateAddress()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateAddress(1234,"ADBCE","1 Main Street");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            Int32 PK = 0;

            TestCustomer.HouseNo = 1;
            TestCustomer.HouseCounty = "Leicestershire";
            TestCustomer.PostCode = "ABCDE";
            TestCustomer.HouseStreet = "1 main street";
            TestCustomer.EMail = "h@h.com";
            TestCustomer.FirstName = "John";
            TestCustomer.LastName = "Smith";
            TestCustomer.PhoneNo = 1234567;
            TestCustomer.Password = "hhhhhhhh";

            AllCustomers.ThisCustomer = TestCustomer;

            PK = AllCustomers.Add();

            TestCustomer.CustomerNo = PK;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            Int32 PK = 0;

            List<clsCustomer> TestList = new List<clsCustomer>();

            TestCustomer.HouseNo = 1;
            TestCustomer.HouseCounty = "Leicestershire";
            TestCustomer.PostCode = "ABCDE";
            TestCustomer.HouseStreet = "1 main street";
            TestCustomer.EMail = "h@h.com";
            TestCustomer.FirstName = "John";
            TestCustomer.LastName = "Smith";
            TestCustomer.PhoneNo = 1234567;
            TestCustomer.Password = "hhhhhhhh";

            AllCustomers.ThisCustomer = TestCustomer;

            PK = AllCustomers.Add();

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
