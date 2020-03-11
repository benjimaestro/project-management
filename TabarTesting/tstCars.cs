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
            //Create an instance of the class we want to create
            clsCars AnCars = new clsCars();
            //test to see that it exists 
            Assert.IsNotNull(AnCars);
        }
    }
}
