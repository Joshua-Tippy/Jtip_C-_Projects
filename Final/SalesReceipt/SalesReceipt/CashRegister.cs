//Written by Joshua Tippy 12/04/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReceipt
{
    class CashRegister
    {
        //variables
        private double price;
        private double tax;
        private double total;
        private double BASETAX = .06; 
        private int quantity;

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
        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }
        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
    
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        //constructor throws error if quantity is greater than units on hand or if quantity is less than zero
        public CashRegister(RetailItem I, int Q)
        {
            if (Q > I.UnitsOnHand)
                throw new ArgumentException("Error: Purchased Quantity can not exceed quantity on hand\n");
            else if (Q < 0)
                throw new ArgumentException("Error: Purchased Quantity can not be less than zero\n");

            Quantity = Q;
            Price = I.Price * Q;
            Tax = Price * BASETAX;
            Total = Price + Tax;
        }
    }
}
