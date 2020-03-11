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
        //This class tests functionality for the Validation class by running functions in an isolated way
        //This makes it easier to debug and find issues in the code
        //For each function in clsValidation, there is a test that checks different possible inputs to see how the function reacts
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
            String Error = clsValidate.ValidatePhone("12345678");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("h@h.c");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("h@h.co");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("h@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMid()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreNotEqual("", Error);
        }


        [TestMethod]
        public void ValidateHouseNoExtremeMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(-1234);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(0);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(1);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(2);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMid()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(5555);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(9998);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(9999);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(10000);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateHouseNo(9999999);
            Assert.AreNotEqual("", Error);
        }




        [TestMethod]
        public void ValidateCountyExtremeMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("ABC");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("ABCD");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("ABCDE");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidatePostCodeExtremeMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABC");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABCD");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABCDE");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABCDEF");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABCDEFG");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABCDEFGH");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePostCode("ABCDEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidateHouseStreetMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("a");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("aaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMid()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidatePhoneNoMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("111111");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("1111111");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("12345678");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMid()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("123456789");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("1234567899");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("12345678999");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("123456789999");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone("1234567899999999999000000000000000000");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidateNameMinMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("", "");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("a", "a");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMinPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("aa", "aa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMid()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMaxMinusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMaxPlusOne()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameExtremeMax()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordExtremeMin()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePassword("","");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordMid()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePassword("Test","Test");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordMismatch()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePassword("Test", "NotTest");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordBlankMismatch()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePassword("Test", "");
            Assert.AreNotEqual("", Error);
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
            TestCustomer.PhoneNo = "1234567";
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
            TestCustomer.PhoneNo = "1234567";
            TestCustomer.Password = "hhhhhhhh";

            AllCustomers.ThisCustomer = TestCustomer;

            PK = AllCustomers.Add();

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
