//Written by Joshua Tippy 12/04/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables to store running totals
            double TotalCost = 0;
            double TotalTax = 0;
            double Total = 0;

            //variables for user input
            const string QUIT = "QUIT";
            string S;
            int U = 0;
            Double P = 0;

            //user input
            Getitem(out S, out U, out P);
            RetailItem item1 = new RetailItem(U, P, S);

            Getitem(out S, out U, out P);
            RetailItem item2 = new RetailItem(U, P, S);

            Getitem(out S, out U, out P);
            RetailItem item3 = new RetailItem(U, P, S);
            string[] items = { (item1.Description).ToUpper(), item2.Description.ToUpper(), item3.Description.ToUpper() };

            Write("Which item would you like to buy? ");
            S = ReadLine().ToUpper();

            //loop iterates while user does not enter 'quit'
            while (S != QUIT)
            {
                U = 0;
                int x = 0;
                //loop tests each item against item user inputs
                foreach (string item in items)
                {
                    if (S == item)
                    {
                        bool T = false;
                        string string1 = "";
                        //loop only allows user to enter an integer not less than zero
                        while (T == false)
                        {
                            Write("How many {0}s are you wanting to buy? ", item.ToString().ToLower());
                            string1 = ReadLine();
                            T = int.TryParse(string1, out U);
                            if (T)
                            {
                                U = Convert.ToInt32(string1);
                                if (U < 0)
                                {
                                    WriteLine("Value can not be less than zero");
                                    T = false;
                                }
                            }
                            else
                                WriteLine("Please enter an integer");
                        }
                        try
                        {
                            //gets cost for item and quantity entered
                            switch (x)
                            {
                                case 0:
                                    double[] values1 = GetCost(item1, U);

                                    TotalCost = TotalCost + values1[1];
                                    TotalTax = TotalTax + values1[2];
                                    Total = Total + values1[3];
                                    break;
                                case 1:
                                    double[] values2 = GetCost(item2, U);

                                    TotalCost = TotalCost + values2[1];
                                    TotalTax = TotalTax + values2[2];
                                    Total = Total + values2[3];
                                    break;
                                case 2:
                                    double[] values3 = GetCost(item3, U);

                                    TotalCost = TotalCost + values3[1];
                                    TotalTax = TotalTax + values3[2];
                                    Total = Total + values3[3];
                                    break;
                            }

                        }
                        catch (Exception e)
                        {
                            WriteLine(e.Message);
                        }
                      
                    }
                    else
                        x++;
                }
                //if loop iterates more than 3 times display 'unknown item'
                if (x == 3)
                    WriteLine("Unknown Item");
                Write("Enter another item or QUIT to get your total: ");
                S = ReadLine().ToUpper();

            }
            //display totals
            WriteLine("SubTotal: {0}\n" +
                "Tax: {1}\n" +
                "Total: {2}", TotalCost.ToString("C"), TotalTax.ToString("C"), Total.ToString("C"));

        }

        //method gets user input
        public static void Getitem(out string S, out int U, out double P)
        {
            S = "";
            U = 0;
            P = 0;
            bool T = false;
            string string1;
            //loop repeats while user does not enter string
            while (S == "")
            {
                Write("Item being purchased: ");
                S = ReadLine();
                if (S == "")
                    WriteLine("Please enter a string");
            }

            //loop only allows user to enter integer not less than zero
            while (T == false)
            {
                Write("Units on hand: ");
                string1 = ReadLine();
                T = int.TryParse(string1, out U);

                if (T)
                {
                    U = Convert.ToInt32(string1);
                    if (U < 0)
                    {
                        WriteLine("Value can not be less than zero");
                        T = false;
                    }
                }
                else
                    WriteLine("Please enter an integer");
            }

            T = false;
            //loop only allows user to enter double not equal to or less than zero
            while (T == false)
            {
                Write("Price: ");
                string1 = ReadLine();
                T = double.TryParse(string1, out P);
                if (T)
                {
                    P = Convert.ToDouble(string1);
                    if (P <= 0)
                    {
                        WriteLine("Value can not be less than or equal to zero");
                        T = false;
                    }
                }
                else
                    WriteLine("Please enter a double");
            }
        }

        //method created CashRegister object and returns it
        public static double[] GetCost(RetailItem item, int U)
        {
            CashRegister R1 = new CashRegister(item, U);

            item.UnitsOnHand = item.UnitsOnHand - U;
            double TotalCost = 0;
            double TotalTax = 0;
            double Total = 0;
            TotalCost = TotalCost + R1.Price;
            TotalTax = TotalTax + R1.Tax;
            Total = Total + R1.Total;
            WriteLine("{0} on hand: {1}", item.Description.ToLower(), item.UnitsOnHand);

            double[] values = { item.UnitsOnHand, TotalCost, TotalTax, Total };
            return values;
        }

    }

}
