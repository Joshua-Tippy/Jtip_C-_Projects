//Written by Joshua Tippy 08/30/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometeres
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            double miles = 0;

            //user input
            Write("Enter miles: ");
            miles = Convert.ToDouble(ReadLine());

            //display
            WriteLine("{0} miles is {1} kilometers", miles, 
                ConvertToKm(miles));
        }

        private static double ConvertToKm(double miles) {
            //Constant variable
            const double KILOMETERS = 1.60934;

            //Variable
            double totalKilometers = 0;

            //calculates total Kilometers
            totalKilometers = miles * KILOMETERS;

            //Returns total Kilometers
            return totalKilometers;

        }
    }
}
