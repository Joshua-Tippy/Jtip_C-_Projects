using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabls
            string wood, desktype = "";

            int drawers;

            //user input
            Write("What kind of wood will your desk use? (Pine-P, Oak-O, Mahogany-M)");
            wood = Convert.ToString(ReadLine());
            if (wood == "P")
                desktype = "Pine";
            else if (wood == "O")
                desktype = "Oak";
            else if (wood == "M")
                desktype = "Mahogany";

            Write("How many drawers will it have? ");
            drawers = Convert.ToInt32(ReadLine());

            //output
            WriteLine("The total of your {1} will be {0}", DeskCalc(wood, drawers).ToString("C"), desktype);
        }

        private static double DeskCalc(string wood, int drawers) {

            //variabels
            double total = 0;
            const int oak = 150, pine = 120, mahogany = 190;

            //Calculations
            switch (wood.ToLower())
            {
                case "p":
                    total = pine + (30 * drawers);
                    break;
                case "o":
                    total = oak + (30 * drawers);
                    break;
                case "m":
                    total = mahogany + (30 * drawers);
                    break;
            }

            return total;
        }
    }
}
