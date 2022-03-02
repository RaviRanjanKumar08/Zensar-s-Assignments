using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Student stud_info
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
            }
        }
        public Course course_info
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        public DateTime enrollDate
        {
            get
            {
                return enrollmentDate;
            }
            set
            {
                enrollmentDate = value;
            }
        }
        public Enroll(Student s, Course c, DateTime enrolldate)
        {
            stud_info = s;
            course_info = c;
            enrollDate = enrolldate;
        }

    }
}
