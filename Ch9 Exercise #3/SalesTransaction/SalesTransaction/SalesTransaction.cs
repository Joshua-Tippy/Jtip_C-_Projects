//Written by Joshua Tippy 10/11/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTransaction
{
    class SalesTransaction
    {
        private string name;
        private double ammount;
        private double commission;
        private readonly double commissionRate;

        public double CommissionRate {
            get
            {
                return commissionRate;
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public double Ammount {
            get
            {
                return ammount;
            }
            set
            {
                ammount = value;
            }
        }

        public double Commission {
            get
            {
                if (commissionRate != 0)
                {
                    commission = commissionRate * ammount;
                }
                return commission;
            }
            set
            {
                commission = value;
            }
        }
        
        //constructors
        public SalesTransaction(string name, double ammount, double rate)
        {
            Name = name;
            Ammount = ammount;
            commissionRate = rate;
        }

        public SalesTransaction(string name, double ammount)
        {
            Name = name;
            Ammount = ammount;
            commissionRate = 0;
        }

        public SalesTransaction(string name)
        {
            Name = name;
            Ammount = 0;
            commissionRate = 0;
        }

        //overloadde +operator
        public static SalesTransaction operator +(SalesTransaction S1, SalesTransaction S2)
        {
            SalesTransaction S3 = new SalesTransaction(S1.Name, S1.Ammount + S2.Ammount);
            S3.Commission = S1.Commission + S2.Commission;
            return S3;
        }

    }
}
