using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Course
    {
        private int Course_ID;
        public int Course_Id
        {
            get
            {
                return Course_ID;
            }
            set
            {
                Course_ID = value;
            }
        }
        private string Course_Name;
        public string Course_name
        {
            get
            {
                return Course_Name;
            }
            set
            {
                Course_Name = value;
            }
        }
        public float Course_Duration { get; set; }
        public float Course_Fees { get; set; }
        public Course(int id, string name, float duration, float fees)
        {
            Course_Id = id;
            Course_name = name;
            Course_Duration = duration;
            Course_Fees = fees;
        }
    }
}
