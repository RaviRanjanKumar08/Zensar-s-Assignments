using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Student
    {
        private int ID;
        public int Student_Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        private string Name;
        public string Student_Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }


        private int Years;
        private int Months;
        private int Days;

        public int AgeInYears
        {
            get
            {
                return Years;
            }
            set
            {
                Years = value;
            }
        }
        public int AgeInMonths
        {
            get
            {
                return Months;
            }
            set
            {
                Months = value;
            }
        }
        public int AgeInDays
        {
            get
            {
                return Days;
            }
            set
            {
                Days = value;
            }
        }

        public Student(int p, string q, int y, int m, int d)
        {
            Student_Id = p;
            Student_Name = q;
            AgeInYears = y;
            AgeInMonths = m;
            AgeInDays = d;
        }
    }
}
