using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class AppEngine
    {
        public static void introduce(List<Course> course)
        {
            for (int i = 0; i < course.Count; i++)
            {
                int id;
                float duration, fee;
                string name;
                Console.WriteLine("Enter Course ID : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration : ");
                duration = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Course Fees : ");
                fee = Convert.ToSingle(Console.ReadLine());
                course.Add(new Course(id, name, duration, fee));
            }
        }

        public static void register(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                int id, y, m, d;
                string name;
                Console.WriteLine("Enter Student ID : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student Birth Year : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Birth Month : ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Birth Day : ");
                d = Convert.ToInt32(Console.ReadLine());
                students.Add(new Student(id, name, y, m, d));
            }
        }

        public static List<Student> ListOfStudents(List<Student> students)
        {
            Info info = new Info();
            for (int i = 0; i < students.Count; i++)
            {
                info.Show(students);
                Console.WriteLine("***********************************************************************************");
            }
            return students;
        }

        public static Course[] ListOfCourses(Course[] course)
        {
            Info info = new Info();
            for (int i = 0; i < course.Length; i++)
            {
                info.Show1(course[i]);
                Console.WriteLine("***********************************************************************************");
            }
            return course;
        }

        public static void enroll(Student[] stud, Course[] cour, List<Enroll> enrolls)
        {
            for (int i = 0; i < stud.Length; i++)
            {
                DateTime edate;
                Console.WriteLine("Enter the Enrollment Date of the Course : ");
                edate = Convert.ToDateTime(Console.ReadLine());
                enrolls.Add(new Enroll(stud[i], cour[i], edate));
            }
        }

        public static List<Enroll> ListOfEnrolment(List<Enroll> enroll_info)
        {
            Info info = new Info();
            info.Show2(enroll_info);
            return enroll_info;
        }
    }
}
