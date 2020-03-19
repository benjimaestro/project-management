using System;
using TabarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TabarTesting
{
    [TestClass]
    public class tstItemType
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class clsItemType
            clsItemType AItemType = new clsItemType();
            //check to see that the class is not null
            Assert.IsNotNull(AItemType);
        }

        [TestMethod]
        public void ItemTypeNoPropertyOK()
        {
            //create an instance f the class we want to create
            clsItemType AItemType = new clsItemType();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AItemType.ItemTypeNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AItemType.ItemTypeNo, TestData);
        }

        [TestMethod]
        public void ItemTypePropertyOK()
        {
            //create an instance f the class we want to create
            clsItemType AItemType = new clsItemType();
            //create some test data to assign to the property
            string SomeItemType = "Car";
            //assign the data to the property
            AItemType.ItemType = SomeItemType;
            //test to see that the two values are the same
            Assert.AreEqual(AItemType.ItemType, SomeItemType);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string SomeItemType = "Car";
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to assign to the property
            Int32 ItemTypeNo = 1;
            //invoke the method
            Found = AItemType.Find(ItemTypeNo);
            //test to see that the result is correct
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ItemTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = ""; //this should trigger an error
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMinBoundary()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "aaa"; //this should be ok
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "aaaa"; //this should be ok
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "aaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemTypeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "aaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeMid()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "aaaaa"; //this should be ok
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsItemType AItemType = new clsItemType();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SomeItemType = "";
            SomeItemType = SomeItemType.PadRight(50, 'a'); //this should fail
            //invoke the method
            Error = AItemType.Valid(SomeItemType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}

