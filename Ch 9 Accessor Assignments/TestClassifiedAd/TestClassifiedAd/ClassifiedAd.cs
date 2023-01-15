//written by Joshua Tippy 10/04/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    class ClassifiedAd
    {
        private double price;
        private int words;
        private string catagory;

        const double CENTSPERWORD = .09;

        //get accessor only, calculates price of Ad
        public double Price {
            get
            {
                price = words * CENTSPERWORD;
                return price;
            }
        }

        //accepts word count of Ad
        public int Words
        {
            get
            {
                return words;
            }
            set
            {
                words = value;
            }
        }

        //accepts catagory of Ad
        public string Catagory
        {
            get
            {
                return catagory;
            }
            set
            {
                catagory = value;
            }
        }
    }
}
