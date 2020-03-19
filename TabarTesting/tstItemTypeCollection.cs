using System;
using TabarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TabarTesting
{
    [TestClass]
    public class tstItemTypeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsItemType
            clsItemTypeCollection AllItemType = new clsItemTypeCollection();
            //check to see that the class is not null
            Assert.IsNotNull(AllItemType);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of our class clsOrder
            clsItemTypeCollection AllItemType = new clsItemTypeCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 10;
            //assign the data to the property
            AllItemType.Count = SomeCount;
            //check to see that the class is not null
            Assert.AreEqual(AllItemType.Count, SomeCount);
        }

        [TestMethod]
        public void AllItemTypeOK()
        {
            //create an instance of the class we want to create
            clsItemTypeCollection ItemType = new clsItemTypeCollection();
            //create some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsItemType> TestList = new List<clsItemType>();
            //add an item to the list
            //create the item of test data
            clsItemType TestItemType = new clsItemType();
            //set its properties
            TestItemType.ItemTypeNo = 1;
            TestItemType.ItemType = "Car";
            //add the item to the test list
            TestList.Add(TestItemType);
            //assign the data to the property
            ItemType.AllItemType = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(ItemType.AllItemType, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsItemTypeCollection ItemType = new clsItemTypeCollection();
            //create some test data to assign to the property
            //in this case that data needs to be a list of objects
            List<clsItemType> TestList = new List<clsItemType>();
            //add an item to the list
            //create the item of test data
            clsItemType TestItemType = new clsItemType();
            //set its properties
            TestItemType.ItemTypeNo = 1;
            TestItemType.ItemType = "Car";
            //add the item to the test list
            TestList.Add(TestItemType);
            //assign the data to the property
            ItemType.AllItemType = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(ItemType.Count, TestList.Count);
        }

    }
}

