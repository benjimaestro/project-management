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
            int SomeCarType = 1;
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
        [TestMethod]
        public void CarTypeMinLessOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarTypeMinBoundaryOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aaa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarTypeMinPlusOneOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aaaa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarTypeMaxLessOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aaaaaaaa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarTypeMaxBoundaryOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aaaaaaaa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarTypeMaxPlusOneOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aaaaaaaaa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarTypeMidOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "aaaaa";
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarExtremeMaxOK()
        {
            clsCarType ACarType = new clsCarType();
            String Error = "";
            string SomeCarType = "";
            SomeCarType = SomeCarType.PadRight(500, 'a');
            Error = ACarType.Valid(SomeCarType);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void TwoCarTypePresent()
        {
            clsCarTypeCollection CarTypes = new clsCarTypeCollection();
            Assert.AreEqual(CarTypes.Count, 2); 
        }
    }
}
