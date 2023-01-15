//written by Joshua Tippy 10/26/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudendGradeDemo
{
    class Student
    {
        private string name;
        private int midterm;
        private int final;
        private double average;
        private char lettergrade;
        const int MIN = 0;
        const int MAX = 100;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Midterm
        {
            get
            {
                return midterm;
            }
            set
            {
                midterm = value;
            }
        }
        public int Final
        {
            get
            {
                return final;
            }
            set
            {
                final = value;
            }
        }
        public char LetterGrade
        {
            get
            {
                return lettergrade;
            }
            set
            {
                lettergrade = value;
            }
        }

        public Student(string n, int m, int f)
        {
            name = n;
            midterm = m;
            final = f;

            if (m < MIN || f < MIN || m > MAX || f > MAX)
                throw new ArgumentException("Error: Grade must be between 0 and 100\n");

            average = (m + f) / 2;
            if (average >= 90)
                lettergrade = 'A';
            else if (average >= 80)
                lettergrade = 'B';
            else if (average >= 70)
                lettergrade = 'C';
            else if (average >= 60)
                lettergrade = 'D';
            else
                lettergrade = 'F';
        }
    }
}
