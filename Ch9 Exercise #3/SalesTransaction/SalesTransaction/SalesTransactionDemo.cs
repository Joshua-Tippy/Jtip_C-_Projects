//Written by Joshua Tippy 10/11/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransaction
{
    class SalesTransactionDemo
    {
        static void Main(string[] args)
        {
            //creates and initialises objects
            SalesTransaction S1 = new SalesTransaction("Sam");
            SalesTransaction S2 = new SalesTransaction("Josh", 60.99);
            SalesTransaction S3 = new SalesTransaction("Joe", 30, .07);
            SalesTransaction S4 = new SalesTransaction("Joe", 53.49, .15);

            //displays each objects
            Display(S1);
            Display(S2);
            Display(S3);
            Display(S4);

            //displays addition of objects
            WriteLine("\nSale1");
            Display(S1);
            
            WriteLine("\nSale1 added to Sale2");
            Display(S1 + S2);

            WriteLine("\nSale1 added to Sale3");
            Display(S1 + S3);

            WriteLine("\nSale3 added to Sale4");
            Display(S3 + S4);
        }

        //method for display
        static void Display(SalesTransaction Display)
        {
            WriteLine("Name: {0} Ammount: {1} Commission: {2}", Display.Name, Display.Ammount.ToString("C"), Display.Commission.ToString("C"));
        }
    }
}
