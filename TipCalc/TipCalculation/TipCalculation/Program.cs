//written by Joshua Tippy 09/20/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double mealPrice = 30.00, tipRate = 0.20;
            int tipInDollars = 5;

            //method with both double arguments
            DisplayTip(mealPrice, tipRate);

            //method with double and int arguments
            DisplayTip(mealPrice, tipInDollars);
        }


        //overloaded method: pass in double and double
        public static void DisplayTip(double mealPrice, double tipRate)
        {
            //varuables
            double tipInDollars, total;

            //calculations
            tipInDollars = mealPrice * tipRate;
            total = tipInDollars + mealPrice;

            //display
            WriteLine("Meal price: {0}. Tip Percent: {1}%. Tip in Dollars: {2}. " +
                "Total: {3}", mealPrice.ToString("C"), tipRate.ToString("F2"), tipInDollars.ToString("C"), total.ToString("C"));

        }

        //overloaded method: pass in double and int
        public static void DisplayTip(double mealPrice, int tipInDollars)
        {
            //variables
            double tipRate, total;

            //calculations
            tipRate = tipInDollars / mealPrice;
            total = tipInDollars + mealPrice;

            //display
            WriteLine("Meal price: {0}. Tip Percent: {1}%. Tip in Dollars: {2}. " +
                "Total: {3}", mealPrice.ToString("C"), tipRate.ToString("F2"), tipInDollars.ToString("C"), total.ToString("C"));
        }
    }
}
