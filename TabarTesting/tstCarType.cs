using System;
using TabarClasses; 
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TabarTesting
{
    [TestClass]
    public class tstCarType
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCarType ACarType = new clsCarType();
            Assert.IsNotNull(ACarType); 
        }
        [TestMethod]
        public void CarTypePropertyOK()
        {
            clsCarType ACarType = new clsCarType();
            string SomeCarType = "HatchBack";
            ACarType.CarType = SomeCarType;
            Assert.AreEqual(ACarType.CarType, SomeCarType); 
        }
        [TestMethod]
        public void CarTypeNumberPropertyOK()
        {
            clsCarType ACarType = new clsCarType();
            string SomeCarType = "HatchBack";
            ACarType.CarTypeNumber = SomeCarType;
            Assert.AreEqual(ACarType.CarTypeNumber, SomeCarType);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = ""; 
            string SomeCarType = "HatchBack";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, ""); 
           
        }
    }
}
