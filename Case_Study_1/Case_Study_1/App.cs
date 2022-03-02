using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class App
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            AppEngine.introduce(courses);
            List<Student> students = new List<Student>();
            AppEngine.register(students);
            AppEngine.ListOfStudents(students);
            AppEngine.ListOfCourses(courses);
            List<Enroll> enroll_infos = new List<Enroll>();
            AppEngine.enroll(students, courses, enroll_infos);
            AppEngine.ListOfEnrolment(enroll_infos);
        }
    }
}
