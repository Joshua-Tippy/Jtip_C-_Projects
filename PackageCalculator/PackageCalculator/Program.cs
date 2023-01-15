//Written by Joshua Tippy 08/25/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int units = 0;
            double total = 0, discount = 0;

            //constants
            const int pkgCost = 99;

            //user input
            Write("Enter the units sold: ");
            units = Convert.ToInt32(ReadLine());

            //calculations
            total = pkgCost * units;

            if (units < 10) 
                discount = 0;
            else if (units < 20)
                discount = (total * .2);
            else if (units < 50)
                discount = (total * .3);
            else if (units < 100)
                discount = (total * .4);
            else if (units > 99)
                discount = (total * .5);
            else
                discount = 0;

            //output
            WriteLine("Units sold: {0}\n" +
                "Discount: {1}\n" +
                "Cost: {2}", units, discount.ToString(("C")), (total - discount).ToString(("C")));
        }
    }
}
