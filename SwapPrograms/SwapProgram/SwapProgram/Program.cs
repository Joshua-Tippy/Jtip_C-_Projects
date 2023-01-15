//Writtem By Joshua Tippy 09/20/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int one = 34, two = 712;

            //Display
            WriteLine("Before swap\n" +
                      "One: {0}\n" +
                      "Two: {1}", one, two);

            //Method Call passes in to reference arguments
            Swap(ref one, ref two);

            //Display
            WriteLine("After swap\n" +
                      "One: {0}\n" +
                      "Two: {1}", one, two);

        }

        //Method accepts two reference arguments
        private static void Swap(ref int one, ref int two) {
            int temp;
            temp = one;
            one = two;
            two = temp;
        }

    }
}
