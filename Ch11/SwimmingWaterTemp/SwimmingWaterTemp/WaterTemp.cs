//written by Joshua Tippy 10/26/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingWaterTemp
{
    class WaterTemp
    {
        //fields
        const int MAX = 85;
        const int MIN = 70;
        const int MAX2 = 212;
        const int MIN2 = 32;
        private int temp;
        private bool comfort;
       
        public bool Comfort
        {
            get
            {
                if (temp > MAX || temp < MIN)
                {
                    comfort = false;
                    return comfort;
                }
                else
                {
                    comfort = true;
                    return comfort;
                }
            }
            set
            {
                comfort = false;
            }
        }

        //constructor accepts one integer value
        public WaterTemp(int t)
        {
            temp = t;
            //throws exception if value is not between 32 and 212
            if (temp > MAX2 || temp < MIN2)
                throw new ArgumentException("Does not fall in expected range, try again");
        }
    }
}
