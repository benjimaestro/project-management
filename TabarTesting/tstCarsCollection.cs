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
            clsCarsCollection AllCollection = new clsCarsCollection();
            Assert.IsNotNull(AllCollection); 
        }
    }
}
