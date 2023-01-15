//written by Joshua Tippy 10/04/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants and variables
            const string ad1 = "Come down to the ice cream shop, we have the best ice cream in town!";
            const string ad2 = "Best selection of used cars in missouri!";
            int count = 1;

            //first ClassifiedAd Object
            ClassifiedAd iceCream = new ClassifiedAd();
            iceCream.Catagory = "IceCream Shop";
            //gets word count of first Ad
            for (int x = 0; x < ad1.Length; x++)
            {
                if (ad1[x] == ' ')
                {
                    count++;
                }
            }
            iceCream.Words = count;
            count = 1;

            //second ClassifiedAd Object
            ClassifiedAd usedCars = new ClassifiedAd();
            usedCars.Catagory = "Car Dealership";
            //gets word count of second Ad
            for (int x = 0; x < ad2.Length; x++)
            {
                if (ad2[x] == ' ')
                {
                    count++;
                }
            }
            usedCars.Words = count;

            //Display
            Display(iceCream, ad1);
            Display(usedCars, ad2);
        }

        //Display method
        static void Display(ClassifiedAd ad, string AdSTR)
        {
            WriteLine("\n{0}" +
                "\nCatagory: {1}" +
                "\nPrice of Ad: {2}", AdSTR, ad.Catagory, ad.Price.ToString("C"));
        }
    }
}
