//written by Joshua Tippy 10/26/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingWaterTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            
            //loop repeats untill user enters 99
            while (temp != 99)
            {
                try
                {
                    //user input
                    Write("Enter a Temperature or 99 to quit >> ");
                    temp = Convert.ToInt32(ReadLine());
                    //creates new object that returns a true or false value, class will throw an exception if number is not between 32 and 212
                    WaterTemp T1 = new WaterTemp(temp);
                    //displays comfortable or not comfortable based on the temp entered
                    if (T1.Comfort == false && temp != 99)
                    {
                        WriteLine("Not Compfortable");
                    }
                    else if (T1.Comfort == true && temp != 99)
                        WriteLine("Comfortable");
                }        
                //catches any errors thrown in main method
                catch (ArgumentException e)
                {
                    WriteLine(e.Message);
                }              
            }
        }
    }
}
