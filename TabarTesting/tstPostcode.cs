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
        public void InstanceOKValidate()
        {
            clsValidate Validator = new clsValidate();
            Assert.IsNotNull(Validator);
        }
        [TestMethod]
        public void InstanceOKCustomer()
        {
            clsCustomer Customer = new clsCustomer();
            Assert.IsNotNull(Customer);
        }
        [TestMethod]
        public void ValidatePhone()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidatePhone(12345678);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void ValidateEmail()
        {
            clsValidate Validator = new clsValidate();
            String Error = clsValidate.ValidateEmail("h@h.com");
            Assert.AreEqual("", Error);
        }
    }
}
