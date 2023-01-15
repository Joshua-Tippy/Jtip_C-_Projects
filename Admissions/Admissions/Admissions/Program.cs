//written by Joshua Tippy 09/07/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int score = 0;
            double gpa = 0;
            string x = " ";

            //user input
            Write("What is your GPA? ");
            gpa = Convert.ToDouble(ReadLine());

            Write("What is your test score? ");
            score = Convert.ToInt32(ReadLine());

            //output
            WriteLine(acceptOrReject(score, gpa));

            //Allows user to avoid entering loop if they wish
            Write("Would you like to test another score? (yes/no) ");
            x = Convert.ToString(ReadLine());

            //Loop allows user to test multiple scores
            while (x != "no") {
                //user input
                Write("What is your GPA? ");
                gpa = Convert.ToDouble(ReadLine());

                Write("What is your test score? ");
                score = Convert.ToInt32(ReadLine());

                //output
                WriteLine(acceptOrReject(score, gpa));

                Write("Would you like to test another score? (yes/no) ");
                x = Convert.ToString(ReadLine());
                x = x.ToLower();
            }
        }

        //Method deciedes weather to return "Accepted" or "Rejected"
        private static string acceptOrReject(int score, double gpa)
        {
            string[] acceptReject = { "Accepted, Congratulations!", "Rejected, try again" };

            if ((score >= 60 && gpa >= 3.0) || (score >= 80 && gpa < 3.0))
            {
                return acceptReject[0];
            }
            else
                return acceptReject[1];
        }
    }
}
