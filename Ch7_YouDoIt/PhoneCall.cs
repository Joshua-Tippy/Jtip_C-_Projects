//Written by Joshua Tippy 08/29/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCall
{
    class Program
    {
        //Method calculates price of phone call
        public static double CalcPhoneCallPrice(int minutes, double rate) {
            const double BASE_FEE = 0.25;
            double callFee;
            callFee = BASE_FEE + minutes * rate;
            return callFee;
        }

        //Main Method
        static void Main(string[] args)
        {
            int[] callLengths = { 2, 5 };
            double[] rates = { 0.03, 0.12 };
            double priceOfCall;

            WriteLine("{0, 10}{1, 10}{2, 10}",
                "Minutes", "Rate", "Price");

            for(int x = 0; x < callLengths.Length; ++x )
                for(int y = 0; y < rates.Length; ++y)
                {
                    priceOfCall = CalcPhoneCallPrice(callLengths[x],
                        rates[y]);
                    WriteLine("{0, 10}{1, 10}{2, 10}",
                        callLengths[x], rates[y], priceOfCall.ToString("C"));
                }
        }

       
    }
}
