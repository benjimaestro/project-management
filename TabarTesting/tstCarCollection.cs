using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;
using System.Collections.Generic; 

namespace TabarTesting
{
    [TestClass]
    public class tstCarCollection
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
            List<clsCars> TestList = new List<clsCars>();
            clsCars TestItem = new clsCars();
            TestItem.CarNo = 1;
            TestItem.CarMake = "Nissan";
            TestItem.CarModel = "Aki";
            TestItem.CarModelNumber = "VRi122";
            TestItem.CarColour = "Blue";
            TestItem.CarPrice = 1;
            TestItem.CarTypeNumber = 1;
            TestItem.CarReleaseDate = "11/10/2001";
            TestList.Add(TestItem);
            AllCars.CarList = TestList;
            Assert.AreEqual(AllCars.CarList, TestList);
        }
        [TestMethod]
        public void ThisCarPropertyOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            clsCars TestCar = new clsCars();
            TestCar.CarNo = 1;
            TestCar.CarMake = "Nissan";
            TestCar.CarModel = "Aki";
            TestCar.CarModelNumber = "VRi122";
            TestCar.CarPrice = 1;
            TestCar.CarColour = "Blue";
            TestCar.CarTypeNumber = 1;
            TestCar.CarReleaseDate = "11/10/2001";
            AllCars.ThisCar = TestCar;
            Assert.AreEqual(AllCars.ThisCar, TestCar); 
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            List<clsCars> TestList = new List<clsCars>(); 
            clsCars TestCar = new clsCars();
            TestCar.CarNo = 1;
            TestCar.CarMake = "Nissan";
            TestCar.CarModel = "Aki";
            TestCar.CarModelNumber = "VRi122";
            TestCar.CarColour = "Blue";
            TestCar.CarPrice = 1;
            TestCar.CarTypeNumber = 1;
            TestCar.CarReleaseDate = "11/10/2001";
            TestList.Add(TestCar);
            AllCars.CarList = TestList;
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCarsCollection AllCars = new clsCarsCollection();
            clsCars TestCar = new clsCars();
            Int32 PrimaryKey = 1;
            TestCar.CarNo = 1;
            TestCar.CarMake = "Mercedes";
            TestCar.CarModel = "S Class";
            TestCar.CarModelNumber = "VRi122";
            TestCar.CarColour = "Blue";
            TestCar.CarPrice = 1;
            TestCar.CarTypeNumber = 1;
            TestCar.CarReleaseDate = "11/10/2001";
            AllCars.ThisCar = TestCar;
            PrimaryKey = AllCars.Add();
            TestCar.CarNo = PrimaryKey;
            AllCars.ThisCar.Find(PrimaryKey);
            Assert.AreEqual(AllCars.ThisCar, TestCar); 

        }

    }
}
