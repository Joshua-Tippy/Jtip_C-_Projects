//written by Joshua Tippy 09/26/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double Salary = 0, Bonus = 0;
            int intBonus = 0;

            //user input
            Write("Enter Salary: ");
            Salary = Convert.ToDouble(ReadLine());

            Write("Enter Bonus Percentage: ");
            Bonus = Convert.ToDouble(ReadLine());

            Write("Enter Bonus Integer: ");
            intBonus = Convert.ToInt32(ReadLine());

            //method with both double arguments
            GetTotal(Salary, Bonus);

            //method with double and int arguments
            GetTotal(Salary, intBonus);
        }


        //overloaded method: pass in double and double
        public static void GetTotal(double Salary, double Bonus)
        {
            //varuables
            double totalBonus, total;

            //calculations
            totalBonus = (Bonus * Salary);
            total = Salary + totalBonus;

            //display
            WriteLine("\nMethod Accepts Double for Salary and Double for Bonus\n" +
                      "Salary: {0}\n" +
                      "Bonus: {1}\n" +
                      "Total: {2}\n", Salary.ToString("C"), totalBonus.ToString("C"), total.ToString("C"));
        }

        //overloaded method: pass in double and int
        public static void GetTotal(double Salary, int Bonus)
        {
            //variables
            double total;

            //calculations
            total = Salary + Bonus;

            //display
            WriteLine("\nMethod Accepts Double for Salary and Integer for Bonus\n" +
                      "Salary: {0}\n" +
                      "Bonus: {1}\n" +
                      "Total: {2}\n", Salary.ToString("C"), Bonus.ToString("C"), total.ToString("C"));
        }
    }
}

