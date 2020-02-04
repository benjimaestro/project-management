using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstStaff1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Test to see that it exists
            Assert.IsNotNull(AnStaff);
        }
    }
}
