//Debugged by Joshua Tippy 09/26/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is $3.99 each

namespace DebugEight1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int orderNum = 0, quantity = 0;
            double total;

            //constant
            const double PRICE_EACH = 3.99;

            //method call
            GetData(out orderNum, out quantity);
            total = quantity * PRICE_EACH;

            //display
            WriteLine("Order #{0}. Quantity ordered = {1}",
                orderNum, quantity);
            WriteLine("Total is {0}", total.ToString("C"));
        }
        private static void GetData(out int orderNum, out int quantity)
        {
            //user input
            String s1, s2;
            Write("Enter order number ");
            s1 = Convert.ToString(ReadLine());
            Write("Enter quantity ");
            s2 = Convert.ToString(ReadLine());
            orderNum = Convert.ToInt32(s1);
            quantity = Convert.ToInt32(s2);
        }
    }
}