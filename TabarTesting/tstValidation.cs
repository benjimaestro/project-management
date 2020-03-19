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
            clsCustomerValidate Validator = new clsCustomerValidate();
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
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("12345678");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("h@h.c");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("h@h.co");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("h@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailMid()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmailExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateEmail("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh@h.com");
            Assert.AreNotEqual("", Error);
        }


        [TestMethod]
        public void ValidateHouseNoExtremeMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(-1234);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(0);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(1);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(2);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMid()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(5555);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(9998);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(9999);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(10000);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseNoExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateHouseNo(9999999);
            Assert.AreNotEqual("", Error);
        }




        [TestMethod]
        public void ValidateCountyExtremeMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("ABC");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("ABCD");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("ABCDE");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateCountyExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateCounty("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidatePostCodeExtremeMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABC");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABCD");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABCDE");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABCDEF");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABCDEFG");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABCDEFGH");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePostCodeExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePostCode("ABCDEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidateHouseStreetMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("a");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("aaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMid()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateHouseStreetExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateStreet("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidatePhoneNoMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("111111");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("1111111");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("12345678");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMid()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("123456789");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("1234567899");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("12345678999");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("123456789999");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePhoneNoExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePhone("1234567899999999999000000000000000000");
            Assert.AreNotEqual("", Error);
        }



        [TestMethod]
        public void ValidateNameMinMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("", "");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("a", "a");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMinPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("aa", "aa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMid()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMaxMinusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameMaxPlusOne()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidateNameExtremeMax()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidateName("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordExtremeMin()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePassword("","");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordMid()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePassword("Test","Test");
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordMismatch()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePassword("Test", "NotTest");
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void ValidatePasswordBlankMismatch()
        {
            clsCustomerValidate Validator = new clsCustomerValidate();
            String Error = clsCustomerValidate.ValidatePassword("Test", "");
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
