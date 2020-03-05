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
            TestItem.EMail = "h@h.com";
            TestItem.FirstName = "HHH";
            TestItem.HouseCounty = "Leicestershire";
            TestItem.HouseNo = 100;
            TestItem.PostCode = "LE27DJ";
            TestItem.HouseStreet = "Main Street";
            TestItem.LastName = "Hjhj";
            TestItem.PhoneNo = 123456789;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        [TestMethod]
        public void DeleteMethodOK()
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
            TestCustomer.Password = "hhhh";

            AllCustomers.ThisCustomer = TestCustomer;
            PK = AllCustomers.Add();
            TestCustomer.CustomerNo = PK;

            AllCustomers.Delete(PK);

            Boolean Found = AllCustomers.ThisCustomer.Find(PK);
            Assert.IsFalse(Found);
        }

        /*[TestMethod]
        public void GetCustomerOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            Assert.AreNotEqual(AllCustomers.GetCustomer(0), TestList);
        }*/
    }
}
