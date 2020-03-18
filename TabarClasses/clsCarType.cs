using System;

namespace TabarClasses
{
    public class clsCarType
    {
        public clsCarType()
        {
        }

        public string CarType { get; set; }
        public string CarTypeNumber { get; set; }

        public string Valid(string someCarType)
        {
           if (someCarType !="")
            {
                return "";
            }
           else
            {
                return "The car type can not be empty!"; 
            }
        }
    }
}