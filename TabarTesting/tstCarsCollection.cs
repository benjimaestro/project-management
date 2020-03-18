using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;
using System.Collections.Generic;

namespace TabarTesting
{
    [TestClass]
    public class tstCarsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            Assert.IsNotNull(AllCars);
        }
        [TestMethod]
        public void CarListOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            List<clsCar> TestList = new List<clsCar>();
            clsCar TestItem = new clsCar();
            TestItem.CarNo = 1;
            TestItem.CarMake = "Mercedes";
            TestItem.CarModel = "S-Class";
            TestItem.CarModelNumber = "VRi78";
            TestItem.CarPrice = 19000;
            TestItem.CarColour = "Red";
            TestItem.CarReleaseDate = "10/10/2009";
            TestItem.CarTypeNumber = 1;
            TestList.Add(TestItem);
            AllCars.CarList = TestList;
            Assert.AreEqual(AllCars.CarList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            Int32 SomeCount = 0;
            AllCars.Count = SomeCount;
            Assert.AreEqual(AllCars.Count, SomeCount);

        }
        [TestMethod]
        public void ThisCarPropertyOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            clsCar TestItem = new clsCar();
            TestItem.CarNo = 1;
            TestItem.CarMake = "Mercedes";
            TestItem.CarModel = "S-Class";
            TestItem.CarModelNumber = "VRi78";
            TestItem.CarPrice = 19000;
            TestItem.CarColour = "Red";
            TestItem.CarReleaseDate = "10/10/2009";
            TestItem.CarTypeNumber = 1;
            AllCars.ThisCar = TestItem;
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            List<clsCar> TestList = new List<clsCar>();
            clsCar TestItem = new clsCar();
            TestItem.CarNo = 1;
            TestItem.CarMake = "Mercedes";
            TestItem.CarModel = "S-Class";
            TestItem.CarModelNumber = "VRi78";
            TestItem.CarPrice = 19000;
            TestItem.CarColour = "Red";
            TestItem.CarReleaseDate = "10/10/2009";
            TestItem.CarTypeNumber = 1;
            TestList.Add(TestItem);
            AllCars.CarList = TestList;
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }


    }
}
