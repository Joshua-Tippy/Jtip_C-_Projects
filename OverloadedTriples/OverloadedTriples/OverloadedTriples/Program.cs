//Written By Joshua Tippy 09/20/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedTriples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varibles
            int num = 20;
            string message = "Go Team!";

            //method passes in int
            Triple(num);

            //method passes in string
            Triple(message);
        }

        //method accepts int
        private static void Triple(int num)
        {
            const int MULT_FACTOR = 3;
            WriteLine("{0} times {1} is {2}\n", num, MULT_FACTOR, num * MULT_FACTOR);
        }

        //method accepts string
        private static void Triple(string message)
        {
            WriteLine("{0}\t{0}\t{0}\n", message);
        }


    }
}
