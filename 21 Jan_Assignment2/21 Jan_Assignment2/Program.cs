using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Jan_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[3];
            int n = 1;
            Console.WriteLine("Program To Check Result of Five Students:");
            while (n<6)
            {
                int total = 0;
                Console.WriteLine($"Enter the Name of student {n}:");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter the marks of {name} in C#, HTML and SQL  from 100:");
                for (int i = 0; i < 3; i++)
                {

                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    total = total + arr[i];
                }
                double avg = total / 3.0;
                if (avg < 50)
                {
                    Console.WriteLine($"{avg} - {name} is Failed");
                }
                else
                {
                    Console.WriteLine($"{avg} - {name} is Passed");
                }
                n++;
            }
        }
    }
}
