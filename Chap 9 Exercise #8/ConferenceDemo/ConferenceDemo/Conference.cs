//Written By Joshua Tippy 10/11/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDemo
{
    class Conference : IComparable
    {

        private string name;
        private string date;
        private int attendees;

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

        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int Attendees
        {
            get
            {
                return attendees;
            }
            set
            {
                attendees = value;
            }
        }

        //constructor
        public Conference(string name, string date, int attendees)
        {
            Name = name;
            Date = date;
            Attendees = attendees;
        }

        //allows sorting of objects
        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Conference temp = (Conference)o;
            if (this.Attendees > temp.Attendees)
                returnVal = 1;
            else
            {
                if (this.Attendees < temp.Attendees)
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            return returnVal;
        }
    }
}
