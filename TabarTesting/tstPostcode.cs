using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TabarClasses;

namespace TabarTesting
{
    [TestClass]
    public class tstPostcode
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsValidate Validator = new clsValidate();
            Assert.IsNotNull(Validator);
        }
    }
}
