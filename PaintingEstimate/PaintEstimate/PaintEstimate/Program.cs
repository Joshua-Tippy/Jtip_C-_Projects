//Written by Joshua Tippy 08/30/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomPaintEstimator
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Array
            double[] length_width_total;

            //Constant variables
            const int HEIGHT = 9, DOLLAR = 6;

            //Method call
            length_width_total = calculateCost(HEIGHT, DOLLAR);

            //display
            WriteLine("The total cost of painting wall {0}ft in length and " + "{1}ft in width is {2}", length_width_total[0],
                length_width_total[1],
                length_width_total[2].ToString("C"));
        }

        //Method asks for user input Calcualtes total and returns an array that contains the length, width, and total
        private static Double[] calculateCost(int HEIGHT, int DOLLAR)
        {
            //user input
            Write("Enter the length:");
            int length = Convert.ToInt32(ReadLine());

            Write("Enter the width:");
            int width = Convert.ToInt32(ReadLine());

            //Calculate
            double cost = ((HEIGHT * length * 2) + (HEIGHT * width * 2));
            double total = cost * DOLLAR;

            //Array
            double[] length_width_total;
            length_width_total = new Double[] { length, width, total };

            //return array
            return length_width_total;
        }
    }
}
