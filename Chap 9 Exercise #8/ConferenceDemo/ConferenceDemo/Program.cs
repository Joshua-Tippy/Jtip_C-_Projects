//Written By Joshua Tippy 10/11/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //created array of 5 objects
            Conference[] conferences = new Conference[5];
            int x;
            int attendees;
            string name;
            string date;

            //loop asks for user input for each object
            for (x = 0; x < conferences.Length; ++x)
            {
                GetData(out name, out date, out attendees);
                conferences[x] = new Conference(name, date, attendees);
            }

            //sorts objects and displays
            Array.Sort(conferences);
            WriteLine("Sorted list: ");
            for (x = 0; x < conferences.Length; ++x)
            {
                Display(conferences[x]);
            }

        }

        //gets user input
        static void GetData(out string name, out string date, out int attendees)
        {
            string inString;
            Write("Please enter Conference groupe name >> ");
            name = ReadLine();

            Write("Please enter the date of Conference {0} >> ", name.ToString());
            date = ReadLine();

            Write("Please enter the number of attendees >> ");
            inString = ReadLine();
            int.TryParse(inString, out attendees);
        }

        //displays objects
        static void Display(Conference C)
        {
            WriteLine("{0}    {1}    Attendees {2}", C.Name, C.Date, C.Attendees);
        }

    }
    
}
