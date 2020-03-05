using System;

namespace TabarClasses
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DOB { get; set; }
        public string PostCode { get; set; }
        public Microsoft.VisualStudio.TestTools.UnitTesting.ITestDataSource HouseNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string TelephoneNo { get; set; }
    }
}