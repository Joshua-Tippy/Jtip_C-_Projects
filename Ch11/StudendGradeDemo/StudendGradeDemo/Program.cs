//written by Joshua Tippy 10/26/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student S1 = new Student("Josh", 95, 80);
                Display(S1);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            try
            {
                Student S2 = new Student("John", -1, 80);
                Display(S2);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            try
            {
                Student S3 = new Student("James", 50, -80);
                Display(S3);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            try
            {
                Student S3 = new Student("Jacob", 59, 97);
                Display(S3);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }

            try
            {
                Student S3 = new Student("James", 87, 110);
                Display(S3);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
        //Display
        static void Display(Student S1)
        {
            WriteLine("No Error\n Name: {0}\n Midterm: {1}\n Final: {2}\n Letter Grade: {3}\n", S1.Name, S1.Midterm, S1.Final, S1.LetterGrade);
        }
    }
}
