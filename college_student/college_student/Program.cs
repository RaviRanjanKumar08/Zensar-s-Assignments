using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college_student
{
        class Program
        {

            abstract class Student
            {
                private string str;
                private int Id;
                private double grade;
                abstract public bool Ispassed(double grade);
            }
            class UnderGrad : Student
            {
                public override bool Ispassed(double grade)
                {
                    if (grade > 70.0)
                        return true;
                    else
                        return false;
                }
            }
            class Grad : Student
            {
                public override bool Ispassed(double grade)
                {
                    if (grade > 80.0)
                        return true;
                    else
                        return false;
                }
            }
                public static void Main(string[] args)
                {

                    double grade;
                    bool res;
                    Console.WriteLine("Enter the grades of under graduate students:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    UnderGrad ug = new UnderGrad();
                    res = ug.Ispassed(grade);
                    Console.WriteLine("Result of under graduated students:" + res);
                    Console.WriteLine("Enter the grades of graduated students:");
                    grade = Convert.ToDouble(Console.ReadLine());
                    Grad gr = new Grad();
                    res = gr.Ispassed(grade);
                    Console.WriteLine("Result of student:" + res);
                }
            
        }

}
