//written by Joshua Tippy 09/14/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fences
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Method calls
            double[] fences_price_squrFt = GetInput();

            double[] totals = GetTotal(fences_price_squrFt[0], fences_price_squrFt[1], fences_price_squrFt[2]);

            //display
            WriteLine("Total gallons of paint: {0} Gallons\n" +
                      "Total hours of labor: {1} Hours\n" +
                      "Cost of paint: {2}\n" +
                      "Cost of labor {3}\n" +
                      "Total job cost: {4}\n",
                      totals[2].ToString("n2"), totals[1].ToString("n2"), totals[4].ToString("C"), totals[3].ToString("C"), totals[0].ToString("C"));
        }

        //Method asks for user input and returns Number of fences, Paint cost per gallon, and total square footage of all fences
        private static Double[] GetInput()
        {
            //variables
            string input = "";
            double squrFt = 0, squrFtRunningTotal = 0, pCost = 0;
            int fNum = 0, num = 0;

            //user input
            Write("Enter the price of paint per gallon: ");
            input = Convert.ToString(ReadLine());

            //do while loop displays error when input is NaN
            do
            {

                if (int.TryParse(input, out num))
                {
                    pCost = Convert.ToDouble(input);
                    num++;
                }
                else
                {
                    Write("Error: NaN: Please enter a number: ");
                    input = Convert.ToString(ReadLine());
                }

            } while (num == 0);

            num = 0;
            Write("Enter the number of fences you would like to paint: ");
            input = Convert.ToString(ReadLine());

            //do while loop displays error when input is NaN
            do
            {
                if (int.TryParse(input, out num))
                {
                    fNum = Convert.ToInt32(input);
                    num++;
                }
                else
                {
                    Write("Error: NaN: Please enter a number: ");
                    input = Convert.ToString(ReadLine());
                }

            } while (num == 0);

            //for loop gets total square footage for each fence and totals them together
            num = 0;
            for (int x = 1; x <= fNum; x++)
            {
                Write("Enter the total square feet for fence {0}: ", x);
                input = Convert.ToString(ReadLine());

                //do while loop displays error when input is NaN
                do
                {
                    if (int.TryParse(input, out num))
                    {
                        squrFt = Convert.ToInt32(input);
                        squrFtRunningTotal = squrFtRunningTotal + squrFt;
                        num++;
                    }
                    else
                    {
                        Write("Error: NaN: Please enter a number: ");
                        input = Convert.ToString(ReadLine());
                    }

                } while (num == 0);
            }

            //returns array stores number of fences, paint cost per gallon, and total square footage of all fences
            double[] fences_price_squrFt = new Double[3] { fNum, pCost, squrFtRunningTotal };
            return fences_price_squrFt;
        }

        //method calculates totals and return array that stores total hours, total Gallons, total paint cost, total labor cost, and total cost
        private static Double[] GetTotal(double fNum, double pCost, double squrFt)
        {
            //constants
            const int hrs = 8, hrsCost = 25, fencePerGallon_Hr = 210;

            //variables
            double hrsTotalCost, pTotalCost, totalGallons, totalHrs; 

            //calculations
            totalGallons = squrFt / fencePerGallon_Hr;
            pTotalCost = totalGallons * pCost;

            totalHrs = (squrFt / fencePerGallon_Hr) * hrs;
            hrsTotalCost = totalHrs * hrsCost;

            //returns array that stores total hours, total Gallons, total paint cost, total labor cost, and total cost
            double[] Total = new Double[5] { hrsTotalCost + pTotalCost, totalHrs, totalGallons, hrsTotalCost, pTotalCost };
            return Total;
        }
    }
}
