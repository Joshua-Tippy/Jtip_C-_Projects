//Written by Joshua Tippy 10/24/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsOnPurpose2
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
            //displays message for Incorrect format error
            catch (FormatException e)
            {
                WriteLine("You did not enter an integer! ");
            }
            //displays message for Divide by zero error
            catch (DivideByZeroException e)
            {
                WriteLine("This is not your fault. ");
                WriteLine("You entered the integer correctly. ");
                WriteLine("The program divides by zero. ");
            }

            WriteLine("The answer is {0} ", answer);
        }
    }
}