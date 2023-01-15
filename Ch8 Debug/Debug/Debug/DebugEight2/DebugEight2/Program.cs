//Debbugged by Joshua Tippy 09/26/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// Overloaded method gives bonus points
// whether grade is a number or letter

namespace DebugEight2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numericScore = 82;
            string letterScore = "B";

            //output and method calls
            Write("Score was {0}. ", numericScore);
            GiveBonus(ref numericScore);
            WriteLine("Now it is {0}.", numericScore);
            Write("Grade was {0} ", letterScore);
            GiveBonus(ref letterScore);
            WriteLine("Now it is {0}", letterScore);
        }
        //method accepts score as Integer
        private static void GiveBonus(ref int testScore)
        {
            const int BONUS = 5;
            testScore = testScore + BONUS;
        }
        //method accepts score as String
        private static void GiveBonus(ref String letterScore)
        {
            const string BONUS = "+";
            letterScore = letterScore + BONUS;
        }
    }
}
