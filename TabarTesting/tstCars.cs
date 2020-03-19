using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstCars
    {
        string CarMake = "Mercedes";
        string CarModel = "S Class";
        string CarModelNumber = "1123";
        string CarReleaseDate = "10/10/2019";
        string CarColour = "Blue";

        [TestMethod]
        public void InstanceOK()
        {
            clsCars ACar = new clsCars();
            Assert.IsNotNull(ACar);
        }
    
        [TestMethod]
        public void CarNoOK()
        {
            clsCars ACar = new clsCars();
            Int32 TestData = 1;
            ACar.CarNo = TestData;
            Assert.AreEqual(ACar.CarNo, TestData);
        }
        [TestMethod]
        public void CarMakeOK()
        {
            clsCars ACar = new clsCars();
            string TestData = "Nissan";
            ACar.CarMake = TestData;
            Assert.AreEqual(ACar.CarMake, TestData);
        }
        [TestMethod]
        public void CarModelOK()
        {
            clsCars ACar = new clsCars();
            string TestData = "Aki";
            ACar.CarModel = TestData;
            Assert.AreEqual(ACar.CarModel, TestData);
        }
        [TestMethod]
        public void CarModelNumberOK()
        {
            clsCars ACar = new clsCars();
            string TestData = "VRi82";
            ACar.CarModelNumber = TestData;
            Assert.AreEqual(ACar.CarModelNumber, TestData);
        }
        [TestMethod]
        public void CarPriceOK()
        {
            clsCars ACar = new clsCars();
            Int32 TestData = 10000;
            ACar.CarPrice = TestData;
            Assert.AreEqual(ACar.CarPrice, TestData);
        }
        [TestMethod]
        public void CarReleaseDateOK()
        {
            clsCars ACar = new clsCars();
            string TestData = "10/10/2019";
            ACar.CarReleaseDate = TestData;
            Assert.AreEqual(ACar.CarReleaseDate, TestData);
        }
        [TestMethod]
        public void CarColourOK()
        {
            clsCars ACar = new clsCars();
            string TestData = "Blue";
            ACar.CarColour = TestData;
            Assert.AreEqual(ACar.CarColour, TestData);
        }
        [TestMethod]
        public void CarTypeNumberOK()
        {
            clsCars ACar = new clsCars();
            Int32 TestData = 1;
            ACar.CarTypeNumber = TestData;
            Assert.AreEqual(ACar.CarTypeNumber, TestData);
        }
        [TestMethod]
        public void FindMethod()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            Assert.IsTrue(Found); 
        }
        [TestMethod]
        public void TestCarNoFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true; 
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarNo !=1)
            {
                OK = false; 
            }
            Assert.IsTrue(OK); 
            
        }
        [TestMethod]
        public void TestCarMakeFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarMake != "Mercedes ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarModelFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarModel != "S Class")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarModelNumberFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarModelNumber != "1123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarPriceFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarPrice != 10000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarReleaseDateFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarReleaseDate != "10/10/2019")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarColourFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarColour != "Blue")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarTypeNumberFound()
        {
            clsCars ACar = new clsCars();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CarNo = 1;
            Found = ACar.Find(CarNo);
            if (ACar.CarTypeNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMinLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMin()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMinPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMaxLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMid()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMaxPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeExtremeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "";
            CarMake = CarMake.PadRight(100000, 'a');
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
    }
}
