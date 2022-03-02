using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Info
    {
        public void Show(List<Student> student)
        {
            var display = from disp in student
                          select disp;
            foreach (var item in display)
            {
                Console.WriteLine("Student ID = {0}", item.Student_Id);
                Console.WriteLine("Name of Student = {0}", item.Student_Name);
                Console.WriteLine("Student Date of Birth = {0}/{1}/{2}", item.AgeInDays, item.AgeInMonths, item.AgeInYears);
            }
        }

        public void Show1(Course course)
        {
            // Console.WriteLine("Student Selected Course Info : ");
            Console.WriteLine("Course ID : {0}", course.Course_Id);
            Console.WriteLine("Course Name : {0}", course.Course_name);
            Console.WriteLine("Course Duration : {0} Months.", course.Course_Duration);
            Console.WriteLine("Course Fees : {0} Rupees.", course.Course_Fees);
        }
        public void Show2(List<Enroll> enrolls)
        {
            var display = from disp in enrolls
                          select disp;
            foreach (var item in display)
            {
                Show(item.stud_info);
                Show1(item.course_info);
                Console.WriteLine("Enrollment Date : {0} ", item.enrollDate);
            }
        }
    }
}
