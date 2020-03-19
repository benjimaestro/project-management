using System;
using TabarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TabarTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        public object TestOrder { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Quality = true;
            TestItem.OrderID = 3;
            TestItem.ItemName = "BMW";
            TestItem.Date = "21/03/2008";
            TestItem.ItemType = "Car";
            TestItem.Price = 44737;
            TestItem.Quantity = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.Quality = true;
            TestOrder.OrderID = 3;
            TestOrder.ItemName = "BMW";
            TestOrder.Date = "21/03/2008";
            TestOrder.ItemType = "Car";
            TestOrder.Price = 44737;
            TestOrder.Quantity = 1;
            //assign the data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the time of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Quality = true;
            TestItem.OrderID = 3;
            TestItem.ItemName = "BMW";
            TestItem.Date = "21/03/2008";
            TestItem.ItemType = "Car";
            TestItem.Price = 44737;
            TestItem.Quantity = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Quality = true;
            TestItem.OrderID = 3;
            TestItem.ItemName = "BMW";
            TestItem.Date = "21/03/2008";
            TestItem.ItemType = "Car";
            TestItem.Price = 44737;
            TestItem.Quantity = 1;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Quality = true;
            TestItem.OrderID = 3;
            TestItem.ItemName = "BMW";
            TestItem.Date = "21/03/2008";
            TestItem.ItemType = "Car";
            TestItem.Price = 44737;
            TestItem.Quantity = 1;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Quality = true;
            TestItem.OrderID = 3;
            TestItem.ItemName = "BMW";
            TestItem.Date = "21/03/2008";
            TestItem.ItemType = "Car";
            TestItem.Price = 44737;
            TestItem.Quantity = 1;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.Quality = false;
            TestItem.OrderID = 3;
            TestItem.ItemName = "Audi A3";
            TestItem.Date = "21/03/2008";
            TestItem.ItemType = "Car";
            TestItem.Price = 30000;
            TestItem.Quantity = 1;
            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            //update the record0
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReportByItemNameMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS CONTAINING UNFILTERED RESULTS
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredItemType = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredItemType.ReportByItemType("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, FilteredItemType.Count);
        }

        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredItemType = new clsOrderCollection();
            //apply a model that doesn't exist
            FilteredItemType.ReportByItemType("xxxxx xxxxxxxxxx xxxx");
            //test  to see that there are no records
            Assert.AreEqual(0, FilteredItemType.Count);
        }

        [TestMethod]
        public void ReportByMethodTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredItemType = new clsOrderCollection();
            //var to store outcomes
            Boolean OK = true;
            //apply a model that doesn't exist
            FilteredItemType.ReportByItemType("121321313212132132131321");
            //check that the correct number of records are found
            if (FilteredItemType.Count == 2)
            {
                //check that the first record is ID 4
                if (FilteredItemType.OrderList[0].OrderID != 9)
                {
                    OK = false;
                }
                //check that the first record is ID 1
                if (FilteredItemType.OrderList[1].OrderID != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsFalse(OK);
        }
    }
}



