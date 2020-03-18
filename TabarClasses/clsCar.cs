using System;

namespace TabarClasses
{
    public class clsCar
    {
        public clsCar()
        {
        }

        public int CarNo { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarModelNumber { get; set; }
        public int CarPrice { get; set; }
        public string CarColour { get; set; }
        public string CarReleaseDate { get; set; }
        public int CarTypeNumber { get; set; }

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