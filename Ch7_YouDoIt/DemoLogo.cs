//Written by Joshua Tippy 08/29/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Our company is ");
            DisplayCompanyLogo();
        }
        private static void DisplayCompanyLogo() {
            WriteLine("See Sharp Optical");
            WriteLine("We prize your eyes");
        }
    }
}
