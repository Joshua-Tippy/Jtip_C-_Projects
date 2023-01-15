//written by Joshua Tippy 10/04/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class CreateStudent
    {

        static void Main()
        {
            //Creates two Student objects and assigns values to all properties
            Student first = new Student();
            Student second = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;

            //Created two Student objects using overloaded constructors
            Student third = new Student(456, "Marco", 2.4);
            Student fourth = new Student();

            //Display
            Display(first);
            Display(second);
            Display(third);
            Display(fourth);
        }

        //method displays student objects
        static void Display(Student stu)
        {
            WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }

    }
}

