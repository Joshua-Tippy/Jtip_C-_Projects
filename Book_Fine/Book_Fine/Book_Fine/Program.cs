//Written By Joshua Tippy 09/07/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Book_Fine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int books;
            int days = 0;
            const double FINE1 = 0.10;
            const double FINE2 = 0.20;
            const int DAY_FINE_INCREASES = 7;

            //user input
            Write("Enter number of books that are overdue >> ");
            books = Convert.ToInt32(ReadLine());

            Write("Enter number of days that the {0} books are overdue >> ", books);
            days = Convert.ToInt32(ReadLine());

            //method call displays output
            displayFine(days, books, FINE1, FINE2, DAY_FINE_INCREASES);
        }

        //method displays output
        private static void displayFine(int days, int books, double FINE1, double FINE2, int DAY_FINE_INCREASES)
        {
            double fine;

            //calculation
            if (days <= DAY_FINE_INCREASES)
                fine = books * days * FINE1;
            else
                fine = books * FINE1 * DAY_FINE_INCREASES +
                   books * FINE2 * (days - DAY_FINE_INCREASES);

            //output
            WriteLine("The fine for {0} book(s) for {1} day(s) is {2}",
               books, days, fine.ToString("C"));
        }
    }
}