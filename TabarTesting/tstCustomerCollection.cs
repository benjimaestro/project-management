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
        //This class tests functionality for the CustomerCollection class by running functions in an isolated way
        //This makes it easier to debug and find issues in the code
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
            TestItem.PhoneNo = "123456789";

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        /*[TestMethod]
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
            TestCustomer.PhoneNo = "1234567";;
            TestCustomer.Password = "hhhh";

            AllCustomers.ThisCustomer = TestCustomer;
            PK = AllCustomers.Add();
            TestCustomer.CustomerNo = PK;

            AllCustomers.Delete(PK);

            Boolean Found = AllCustomers.ThisCustomer.Find(PK);
            Assert.IsFalse(Found);
        }*/

        [TestMethod]
        public void UpdateMethodOK()
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
            TestCustomer.PhoneNo = "1234567";;
            TestCustomer.Password = "hhhh";

            AllCustomers.ThisCustomer = TestCustomer;
            PK = AllCustomers.Add();
            TestCustomer.CustomerNo = PK;

            TestCustomer.HouseNo = 1;
            TestCustomer.HouseCounty = "HHHLeicestershire";
            TestCustomer.PostCode = "HHHHHH";
            TestCustomer.HouseStreet = "H main street";
            TestCustomer.EMail = "hHHHHHH@h.com";
            TestCustomer.FirstName = "HHHJohn";
            TestCustomer.LastName = "HHHSmith";
            TestCustomer.PhoneNo = "91234567";
            TestCustomer.Password = "HHHHHHH";

            AllCustomers.ThisCustomer = TestCustomer;
            AllCustomers.Update();
            //AllCustomers.ThisCustomer.Find();
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ReportByEMailMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByEMail("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByEMailNoneFound()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByEMail("xxxxxxxxxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByEMailTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;

            FilteredCustomers.ReportByEMail("DONOTUSE@h.com");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerNo != 32)
                { OK = false; }
                if (FilteredCustomers.CustomerList[1].CustomerNo != 33)
                { OK = false; }
            }
            else
            { OK = false; }

            Assert.IsTrue(OK);
        }
    }
}
