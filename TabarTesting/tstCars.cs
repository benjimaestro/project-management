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
        public void FindMethodOK()
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
            Assert.AreNotEqual(Error, "");

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
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMinPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMaxLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMid()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

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
        [TestMethod]
        public void CarModelMinLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMin()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "a";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMinPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "aa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMaxLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMid()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelExtremeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModel = "";
            CarMake = CarMake.PadRight(100000, 'a');
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMinLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMin()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "a";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMinPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "aa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMaxLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "aaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "aaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMid()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "aaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberMaxPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "aaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelNumberExtremeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarModelNumber = "";
            CarMake = CarMake.PadRight(100000, 'a');
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMinLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMin()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "aaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMinPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "aaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMaxLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "aaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "aaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMid()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "aaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourMaxPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "aaaaaaaaaaaaaaaaaaaaaa";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarColourExtremeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarColour = "";
            CarMake = CarMake.PadRight(100000, 'a');
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMinLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMin()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "10/10/1998";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMinPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "10/10/19988";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMaxLessOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "9/09/1998";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "10/10/1998";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMid()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarMake = "9/9/98";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateMaxPlusOne()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "10/10/19988";
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarReleaseDateExtremeMax()
        {
            clsCars ACar = new clsCars();
            String Error = "";
            string CarReleaseDate = "";
            CarReleaseDate = CarReleaseDate.PadRight(100000, 'a');
            Error = ACar.Valid(CarMake, CarModel, CarModelNumber, CarColour, CarReleaseDate);
            Assert.AreNotEqual(Error, "");

        }
        
    }
}
