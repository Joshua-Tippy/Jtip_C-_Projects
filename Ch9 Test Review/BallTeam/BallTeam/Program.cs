//Written by Joshua Tippy 10/19/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] Players = new Player[5];
            int x = 0;
            string name;
            double average;

            for (x = 0; x < Players.Length; ++x)
            {
                GetData(out name, out average);
                Players[x] = new Player(name, average);
            }

            Array.Sort(Players);
            WriteLine("Sorted list: ");
            for (x = 0; x < Players.Length; ++x)
            {
                Display(Players[x]);
            }
        }

        static void GetData(out string name, out double average)
        {
            string inString;
            Write("Please enter player name >> ");
            name = ReadLine();
            
            Write("Please enter batting average for {0} >> ", name);
            inString = ReadLine();
            double.TryParse(inString, out average);
        }

        static void Display(Player P)
        {
            WriteLine("{0}    {1}", P.Name, P.Average);
        }
    }
}
