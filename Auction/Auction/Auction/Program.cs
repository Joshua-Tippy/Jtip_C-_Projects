//Written By Joshua Tippy 09/20/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int intBid = 0, inputLength, y = 0;
            double doubleBid = 0;
            string stringBid = "", input;
            bool VI = true;

            //user input
            Write("Enter your bid: ");
            input = Convert.ToString(ReadLine());
            inputLength = input.Length;

            //loop tests if input is in valid format
            do
            {
                //check if input is int
                if (Int32.TryParse(input, out intBid))
                {
                    for (int x = 0; x != 1;)
                    {
                        if (intBid >= 10)
                        {
                            VI = true;
                            Bid(intBid);
                            x = x + 1;
                        }
                        else
                        {
                            Write("Bid Must Be atleast 10 Dollars: Enter your bid: ");
                            intBid = Convert.ToInt32(ReadLine());
                        }
                    }
                }

                //checks if input is a double
                else if (double.TryParse(input, out doubleBid))
                {
                    for (int x = 0; x != 1;)
                    {
                        if (doubleBid >= 10)
                        {
                            VI = true;
                            Bid(doubleBid);
                            x = x + 1;
                        }
                        else
                        {
                            Write("Bid Must Be atleast 10 Dollars: Enter your bid: ");
                            doubleBid = Convert.ToDouble(ReadLine());
                        }
                    }
                }

                //checks if input string starts with $
                else if (input[0] == '$')
                {
                    //extracts integer from string
                    doubleBid = Convert.ToDouble(input.Substring(1));

                    //loop only accepts bids of atleast 10 dollars
                    for (int x = 0; x != 1;)
                    {
                        if (doubleBid >= 10)
                        {
                            VI = true;
                            stringBid = doubleBid.ToString("C");
                            Bid(stringBid);
                            x = x + 1;
                        }
                        else
                        {
                            Write("Bid Must Be atleast 10 Dollars: Enter your bid: $");
                            doubleBid = Convert.ToDouble(ReadLine());
                        }
                    }
                }

                //check if input string contains 'dollars'
                else if (input.Substring(inputLength - 7,7).ToLower() == "dollars")
                {
                    //loop finds the index where numbers stop
                    for (char x = 'a'; x != ' ' || y == 9;)
                    {
                        x = input[y];
                        y = y + 1;
                    }

                    //extracts integer from string
                    doubleBid = Convert.ToDouble(input.Substring(0, y - 1));
                    
                    //loop tests if input is atleast 10
                    for (int x = 0; x != 1;)
                    {
                        if (doubleBid >= 10)
                        {
                            VI = true;
                            stringBid = doubleBid.ToString() + " Dollars";
                            Bid(stringBid);
                            x = x + 1;
                        }
                        else
                        {
                            Write("Bid Must Be atleast 10 Dollars: Enter your bid $");
                            doubleBid = Convert.ToDouble(ReadLine());
                        }
                    }
                }

                else
                {
                    Write("Incorrect format, Try again: ");
                    input = Convert.ToString(ReadLine());
                    VI = false;
                }
            } while (VI == false);
        }
        
        //accepts int
        private static void Bid(int bid)
        {
            WriteLine("Accepted!  Your Bid is: {0}", bid.ToString("C"));
        }

        //accepts double
        private static void Bid(double bid)
        {
            WriteLine("Accepted!  Your Bid is: {0}", bid.ToString("C"));
        }

        //accepts string
        private static void Bid(string bid)
        {
            WriteLine("Accepted!  Your Bid is: {0}", bid);
        }
    }
}
