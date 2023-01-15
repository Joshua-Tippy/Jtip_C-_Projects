//Written by Joshua Tippy 10/24/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsOnPurpose_YDI_Pg489
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int answer = 0;
            int result;
            int zero = 0;

            try
            {
                Write("Enter an integer >> ");
                answer = Convert.ToInt32(ReadLine());
                result = answer / zero;
            }

            //displays messages for any errors that may ocur
            catch(Exception e)
            {
                WriteLine(e.Message);
            }

            WriteLine("The answer is {0} ", answer);
        }
    }
}
