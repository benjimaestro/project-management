using System;
using System.Linq;
using System.Text; 
using System.Collections.Generic;

namespace TabarClasses
{
    public class clsCarTypeCollection
    {
        public clsCarTypeCollection()
        {
            clsCarType ACarType = new clsCarType();
            ACarType.CarType = "Hatchback";
            mAllCarTypes.Add(ACarType);
            ACarType = new clsCarType();
            ACarType.CarType = "Coupe";
            mAllCarTypes.Add(ACarType); 
        }
        private List<clsCarType> mAllCarTypes = new List<clsCarType>(); 
        public int Count 
        {
            get
            {
                return mAllCarTypes.Count; 
            }
            set
            {

            }
        }
        public List<clsCarType> AllCarTypes 
        {
            get
            {
                return mAllCarTypes; 
            }
            set
            {
                mAllCarTypes = value; 
            }
        }
    }
}