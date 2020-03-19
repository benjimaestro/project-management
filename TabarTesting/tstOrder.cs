using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstOrder
    {

        string ItemName = "BMW";
        //good test data
        //create some test data to pass to pass to the method
        string Price ="300000";
        string Date = DateTime.Now.Date.ToString();
        String Quantity = "1";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

         [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "BMW";
            //assign the data to the property
            AnOrder.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemName, TestData);

        }

        [TestMethod]
        public void ItemTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Car";
            //assign the data to the property
            AnOrder.ItemType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemType, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance f the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 25690;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "10/03/2020";
            //assign the data to the property
            AnOrder.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Date, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void QualityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Quality = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quality, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the Order ID
            if (AOrder.OrderID != 8)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the Car ID
            if (AOrder.ItemName != "BMW")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemTypeFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the order ID
            if (AOrder.ItemType != "Car")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the Car ID
            if (AOrder.Price != 25690.00m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the Car ID
            if (AOrder.Quantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the order ID
            if (AOrder.Date != "21/03/2008")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQualityFound()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            // boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some data to use with the method
            Int32 OrderID = 8;
            //invoke the method
            Found = AOrder.Find(OrderID);
            //check the Car ID
            if (AOrder.Quality != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AOrder.Valid(ItemName,Price,Quantity,Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "a"; //this should trigger an error
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is     correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMin()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aa"; //this should be ok
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaa"; //this should be ok
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa "; //this should be ok
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaa ";
            //this should be ok
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa "; //this should fail
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemName = "";
            ItemName = ItemName.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years 
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day 
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable 
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable 
            String Date = TestDate.ToString();
            //invoke the method 
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateExtrmeMax()
        {
            //create an instance of the class we want to create 
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable 
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateInvalidDate()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set date to a non date value
            string Date = "This is not a date";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "0";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "12";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "29";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantitMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "30";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "31";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "100";
            //this should fail
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "15" ;
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "09";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "10";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "11";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "599990";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "6000000";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "60000001";
             //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "100000000";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "300000";
            //invoke the method
            Error = AOrder.Valid(ItemName, Price, Quantity, Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
