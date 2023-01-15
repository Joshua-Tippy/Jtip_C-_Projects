//written by Joshua Tippy 10/25/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SubscriptExeptionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //array
            double[] array = { 5.5, 12.3, 18.3, 29.97, 83.09, 27.0038, 54.1, .05, -.9375, 50 };

            //variables
            const int QUIT = 99;
            int subscript;

            //user input
            Write("Enter a subscript value or 99 to quit: ");
            subscript = Convert.ToInt32(ReadLine());

            while(subscript != QUIT)
            {
                try
                {
                    //display value stored in coresponding array position
                    WriteLine("The value is {0}", array[subscript]);
                }
                catch(IndexOutOfRangeException e)
                {
                    //display error message
                    WriteLine(e.Message);
                }
                //ask user again
                Write("Enter a subscript value or 99 to quit: ");
                subscript = Convert.ToInt32(ReadLine());
            }
        }
    }
}
