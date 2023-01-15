//Written By Joshua Tippy 10/11/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student3
{
    class CreateStudent3
    {
        static void Main(string[] args)
        {

            Student3[] students = new Student3[8];
            int x;
            int id;
            string name;
            double gpa;

            for (x = 0; x < students.Length; ++x)
            {
                GetData(out id, out name, out gpa);
                students[x] = new Student3(id, name, gpa);
            }

            Array.Sort(students);
            WriteLine("Sorted list: ");
            for(x = 0; x < students.Length; ++x)
            {
                Display(students[x]);
            }

        }

        static void GetData(out int id, out string name, out double gpa)
        {
            string inString;
            Write("Please enter student ID number >> ");
            inString = ReadLine();
            int.TryParse(inString, out id);
            Write("Please enter last name for student {0} >> ", id);
            name = ReadLine();
            Write("Pleasr enter grade point average >> ");
            inString = ReadLine();
            double.TryParse(inString, out gpa);
        }

        static void Display(Student3 S)
        {
            WriteLine("{0}    {1}       {2}", S.IdNumber, S.LastName, S.GradePointAverage.ToString("n2"));
        }
    }
}
