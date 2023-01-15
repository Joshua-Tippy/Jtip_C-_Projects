//Written by Joshua Tippy 10/19/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallTeam 
{
    class Player : IComparable
    {
        private string name;
        private double average;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Average
        {
            get
            {
                return average;
            }
            set
            {
                average = value;
            }
        }

        public Player(string n, double a)
        {
            Name = n;
            Average = a;
        }

        public Player() : this("XXXXX", 0.0)
        {
        }

        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Player temp = (Player)o;
            if (this.Average > temp.Average)
                returnVal = 1;
            else
            {
                if (this.Average < temp.Average)
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            return returnVal;
        }
    }
}
