using System;

namespace TabarClasses
{
    public class clsCar
    {
        public clsCar()
        {
        }

        public string CarType { get; set; }
        public int CarTypeNo { get; set; }

        public string Valid(string someCarType)
        {
            //if the name of the car type is not blank 
            if (someCarType != "")
            {
                //return a blank string 
                return "";
            }
            else
            {
                //otherwise return an error message 
                return "The car type can not be blank !"; 
            }
        }
    }
}