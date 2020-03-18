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
    }
}
