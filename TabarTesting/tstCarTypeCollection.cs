using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;
using System.Collections.Generic; 

namespace TabarTesting
{
    [TestClass]
    public class tstCarTypeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCarTypeCollection AllCarTypes = new clsCarTypeCollection();
            Assert.IsNotNull(AllCarTypes);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsCarTypeCollection AllCarTypes = new clsCarTypeCollection();
            Int32 SomeCount = 6;
            AllCarTypes.Count = SomeCount;
            Assert.AreEqual(AllCarTypes.Count, SomeCount);
        }
        [TestMethod]
        public void AllCarTypesOK()
        {
            clsCarTypeCollection CarTypes = new clsCarTypeCollection();
            List<clsCarType> TestList = new List<clsCarType>();
            clsCarType TestItem = new clsCarType();
            TestItem.CarTypeNo = 1;
            TestItem.CarType = "Hatchback";
            TestList.Add(TestItem);
            CarTypes.AllCarTypes = TestList;
            Assert.AreEqual(CarTypes.AllCarTypes, TestList);
        }
        [TestMethod]
        public void CountMatchesList()
        {
            clsCarTypeCollection CarTypes = new clsCarTypeCollection();
            List<clsCarType> TestList = new List<clsCarType>();
            clsCarType TestItem = new clsCarType();
            TestItem.CarTypeNo = 1;
            TestItem.CarType = "Hatchback";
            TestList.Add(TestItem);
            CarTypes.AllCarTypes = TestList;
            Assert.AreEqual(CarTypes.Count, TestList.Count);
        }
    }
}
