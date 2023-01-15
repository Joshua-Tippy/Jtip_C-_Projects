//Written by Joshua Tippy 12/04/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReceipt
{
    class RetailItem
    {
        //variables
        private string description;
        private int unitsOnHand;
        private double price;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public int UnitsOnHand
        {
            get
            {
                return unitsOnHand;
            }
            set
            {
                unitsOnHand = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        //constructor assigns values entered by user to new retailitem object
        public RetailItem(int U, double P, string D)
        {
            Description = D;
            UnitsOnHand = U;
            Price = P;
        }
    }
}
