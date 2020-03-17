?using System;
using TabarClasses;

namespace TabarClasses
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DOB { get; set; }
        public string PostCode { get; set; }
        public int HouseNo { get; set; }
        public string Street { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string TelephoneNo { get; set; }
        public int StaffNo { get; set; }
        public object Department { get; internal set; }

        public void Find(int primaryKey)
        {
            throw new NotImplementedException();
        }

        public string Valid(object text1, object text2, object text3, object text4, object text5, object text6, object text7, object text8)
        {
            throw new NotImplementedException();
        }
    }
}