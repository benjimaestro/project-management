using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;
using System.Collections.Generic;
using System.Diagnostics;

namespace TabarTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Email = "h@h.com";
            TestItem.FirstName = "HHH";
            TestItem.HouseCounty = "Leicestershire";
            TestItem.HouseNo = 100;
            TestItem.HousePostcode = "LE27DJ";
            TestItem.HouseStreet = "Main Street";
            TestItem.LastName = "Hjhj";
            TestItem.PhoneNumber = 123456789;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        [TestMethod]
        public void GetCustomerOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            Assert.AreNotEqual(AllCustomers.GetCustomer(0), TestList);
        }
    }
}
