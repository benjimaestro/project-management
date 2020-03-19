using System;

namespace TabarClasses
{
    public class clsCarType
    {
        public clsCarType()
        {
        }

        public string CarType { get; set; }
        public int CarTypeNo { get; set; }

        public string Valid(string someCarType)
        {
            string Error = ""; 
           if (someCarType.Length > 9)
            {
                Error = "The county name can not be more than 9 characters ";
            }
           if (someCarType.Length == 0)
            {
                Error = "The car type can not be blank"; 
            }
            return Error; 
        }
    }
}