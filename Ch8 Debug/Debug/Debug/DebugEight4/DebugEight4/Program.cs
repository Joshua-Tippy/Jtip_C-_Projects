//Debugged By Joshua Tippy 09/27/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Program demonstrates overloaded methods
// that display an int, an amount of money, or a string
// decorated with an argument character
// or a default character 'X'

namespace DebugEight4
{
    class Program
    {
        static void Main(string[] args)
        {
            //method calls
            FancyDisplay(33);
            FancyDisplay(44, '@');
            FancyDisplay(5.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');
        }
        //method accepts a integer and an optional char
        private static void FancyDisplay(int num, char decoration = 'X')
        {
            WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
               decoration, num);
        }
        //method accepts a double and an optional char
        private static void FancyDisplay(double num, char decoration = 'X')
        {
            WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
               decoration, num.ToString("C"));
        }
        //method accepts a string and an optional char
        private static void FancyDisplay(string word, char decoration = 'X')
        {
            WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
               decoration, word);
        }
    }
}
