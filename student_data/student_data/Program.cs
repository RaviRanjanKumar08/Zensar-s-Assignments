using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_data
{
    class student
    {
        private int rollNo, sem;
        private string name, branch, classs;
        public int[] marks = new int[5];
        student(int rollNo, string name, string classs, int sem, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.classs = classs;
            this.sem = sem;
            this.branch = branch;
        }
        public void showResult()
        {
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / 5.0;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("Not passed");
                    return;
                }
            }
            if (avg < 50)
            {
                Console.WriteLine("Not passed");
                return;
            }
            Console.WriteLine("Passed");
        }
        public void showValue()
        {
            Console.WriteLine("roll No: " + rollNo);
            Console.WriteLine("name: " + name);
            Console.WriteLine("class: " + classs);
            Console.WriteLine("sem: " + sem);
            Console.WriteLine("branch: " + branch);
        }
        public static void Main(string[] args)
        {
            int r, s;
            String n, b, c;
            Console.WriteLine("Enter the name of student: ");
            n = Console.ReadLine();
            Console.WriteLine("Enter the class of student: ");
            c = Console.ReadLine();
            Console.WriteLine("Enter the branch of student: ");
            b = Console.ReadLine();
            Console.WriteLine("Enter the roll No of student: ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sem: ");
            s = Convert.ToInt32(Console.ReadLine());
            student S = new student(r, n, c, s, b);
            Console.WriteLine("Enter marks of all subject: ");
            for (int i = 0; i < 5; i++)
            {
                S.marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            S.showResult();
            S.showValue();
        }
    }
}
