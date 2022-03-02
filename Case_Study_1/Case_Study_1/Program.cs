using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
    internal class Program
    {
        public static void Scenario1Student()
        {
            Student s1 = new Student(101, "Rohan", 1997, 11, 10);
            Student s2 = new Student(102, "Aakash", 1999, 12, 22);
            Student s3 = new Student(103, "Shubham", 2000, 01, 31);
            Student s4 = new Student(104, "Subhash", 1998, 05, 13);
            Info i1 = new Info();
            i1.Show(s1);
            Console.WriteLine("***********************************************************************************");
            i1.Show(s2);
            Console.WriteLine("***********************************************************************************");
            i1.Show(s3);
            Console.WriteLine("***********************************************************************************");
            i1.Show(s4);
            Console.WriteLine("***********************************************************************************");
        }
        public static void Scenario2Student()
        {
            Student[] students =
            {
                new Student(111, "Mohan", 1996, 03, 01),
                new Student(112, "Hemansh", 1999, 08, 02),
                new Student(113, "Sarad", 2000, 06, 19),
                new Student(114, "Harshad", 1998, 11, 21)
            };
            Info i2 = new Info();

            i2.Show(students[0]);
            Console.WriteLine("***********************************************************************************");
            i2.Show(students[1]);
            Console.WriteLine("***********************************************************************************");
            i2.Show(students[2]);
            Console.WriteLine("***********************************************************************************");
            i2.Show(students[3]);
            Console.WriteLine("***********************************************************************************");
        }
        public static void Scenario1Course()
        {
            Course c1 = new Course(11, "Java FullStack", 07, 10000);
            Course c2 = new Course(12, "Data Structures & Algo", 08, 15000);
            Course c3 = new Course(13, "JavaScript", 05, 25000);
            Course c4 = new Course(14, "C#", 10, 20000);
            Info i1 = new Info();
            i1.Show1(c1);
            Console.WriteLine("***********************************************************************************");
            i1.Show1(c2);
            Console.WriteLine("***********************************************************************************");
            i1.Show1(c3);
            Console.WriteLine("***********************************************************************************");
            i1.Show1(c4);
            Console.WriteLine("***********************************************************************************");
        }
        public static void Scenario2Course()
        {
            Course[] course =
            {
                new Course(01, "Java FullStack", 06, 20000),
                new Course(02, "Dot NET", 03, 25000),
                new Course(03, "Python", 03, 15000),
                new Course(04, "AI & ML", 09, 30000)
            };
            Info i2 = new Info();
            i2.Show1(course[0]);
            Console.WriteLine("***********************************************************************************");
            i2.Show1(course[1]);
            Console.WriteLine("***********************************************************************************");
            i2.Show1(course[2]);
            Console.WriteLine("***********************************************************************************");
            i2.Show1(course[3]);
            Console.WriteLine("***********************************************************************************");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("    SCENARIO OF STUDENT ClASS STARTS ");
            Console.WriteLine("    START OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Scenario1Student();
            Console.WriteLine("      END OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Console.WriteLine("      START OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Scenario2Student();
            Console.WriteLine("       END OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Console.WriteLine("       START OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Scenario1Course();
            Console.WriteLine("        END OF SCENARIO : 1 !!!!!!!!!!!!!!!!");
            Console.WriteLine("        START OF SCENARIO : 2 !!!!!!!!!!!!!!!!");
            Scenario2Course();
            Console.WriteLine("         END OF SCENARIO : 2 !!!!!!!!!!!!!!!!");


        }
    }
}
