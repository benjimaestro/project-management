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
        
        [TestMethod]
        public void CarTypeOK()
        {
            clsCar ACar = new clsCar();
            //create an instance of the class we want to create 
            string SomeCarType = "Hatchback";
            //create some test data to assign to the property 
            ACar.CarType = SomeCarType;
            //assign the data to the property 
            Assert.AreEqual(ACar.CarType, SomeCarType); 
        }

        [TestMethod]
        public void CarTypeNoOK()
        {
            clsCar ACar = new clsCar();
            //create an instance of the class we want to create 
            Int32 CarTypeNo = 1;
            //create some test data to assign to the property 
            ACar.CarTypeNo = CarTypeNo;
            //assign the data to the property 
            Assert.AreEqual(ACar.CarTypeNo, CarTypeNo);
        }
    }  


}
