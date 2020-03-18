using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstCars
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCar ACar = new clsCar();
            //create an instance of the class we want to create 
            Assert.IsNotNull(ACar);
            //test to see that it exists 
        }


        public void ValidMethodOK()
        {
            clsCar ACar = new clsCar();
            //create an instance of the class we want to create 
            String Error = "";
            //create a string variable to store the result of the validation
            string SomeCarType = "Hatchback";
            //Create some test data to test the method 
            Error = ACar.Valid(SomeCarType);
            //invoke the method 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarTypeLessOne()
        {
            clsCar ACar = new clsCar();
            //create an instance of the class we want to create 
            String Error = "";
            //create a string variable to store the result of the validation
            string SomeCarType = "";
            //Create some test data to test the method 
            Error = ACar.Valid(SomeCarType);
            //invoke the method 
            Assert.AreEqual(Error, "");
            //test to see that the result is NOT OK i.e there should be an error message 
        }

        [TestMethod]
        public void CarNoPropertyOK()
        {
            clsCar ACar = new clsCar();
            Int32 TestData = 1;
            ACar.CarNo = TestData;
            Assert.AreEqual(ACar.CarNo, TestData);
        }
        [TestMethod]
        public void CarMakePropertyOK()
        {
            clsCar ACar = new clsCar();
            string TestData = "Nissan";
            ACar.CarMake = TestData;
            Assert.AreEqual(ACar.CarMake, TestData);
        }
        [TestMethod]
        public void CarModelPropertyOK()
        {
            clsCar ACar = new clsCar();
            string TestData = "VRJJi8";
            ACar.CarModel = TestData;
            Assert.AreEqual(ACar.CarModel, TestData);
        }
        [TestMethod]
        public void CarModelNumberPropertyOK()
        {
            clsCar ACar = new clsCar();
            string TestData = "112Ki";
            ACar.CarModelNumber = TestData;
            Assert.AreEqual(ACar.CarModelNumber, TestData);
        }
        [TestMethod]
        public void CarPricePropertyOK()
        {
            clsCar ACar = new clsCar();
            int TestData = 1;
            ACar.CarPrice = TestData;
            Assert.AreEqual(ACar.CarPrice, TestData);
        }
        [TestMethod]
        public void CarColourPropertyOK()
        {
            clsCar ACar = new clsCar();
            string TestData = "Green";
            ACar.CarColour = TestData;
            Assert.AreEqual(ACar.CarColour, TestData);
        }
        [TestMethod]
        public void CarReleaseDatePropertyOK()
        {
            clsCar ACar = new clsCar();
            string TestData = "10/10/1998";
            ACar.CarReleaseDate = TestData;
            Assert.AreEqual(ACar.CarReleaseDate, TestData);
        }
        [TestMethod]
        public void CarTypeNumberPropertyOK()
        {
            clsCar ACar = new clsCar();
            int TestData = 1;
            ACar.CarTypeNumber = TestData;
            Assert.AreEqual(ACar.CarTypeNumber, TestData);
        }


    }


}
