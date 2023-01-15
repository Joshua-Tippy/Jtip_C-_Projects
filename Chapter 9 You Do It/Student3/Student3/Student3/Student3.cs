//Written By Joshua Tippy 10/11/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student3
{
    class Student3 : IComparable
    {

        private int idNumber;
        private string lastName;
        private double gradePointAverage;

        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0;

        //accepts integer for id number of student
        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }

        //accepts string for last name of student
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        //accepts double for grade point average
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }

        //overloaded Constructor
        public Student3(int id, string name, double gpa)
        {
            IdNumber = id;
            LastName = name;
            GradePointAverage = gpa;
        }

        //overloaded Constructor passes in default values
        public Student3() : this(0, "XXX", 0.0)
        {
        }

        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Student3 temp = (Student3)o;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else
            {
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            return returnVal;
        }
    }
}
