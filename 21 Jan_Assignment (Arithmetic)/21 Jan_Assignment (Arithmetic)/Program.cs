using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Jan_Assignment__Arithmetic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string str = Console.ReadLine();
            Console.WriteLine($"Hi! {str} \n Welcome to the world of C#");
            Console.WriteLine($"OK {str}, Now, Input a number to check even or not");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{str}, {num} is an even number");
            }
            else
            {
                Console.WriteLine($"{str}, {num} is an odd number");
            }
            Console.WriteLine("Now Enter three numbers for fun and we will find which is smallest or largest among them");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine($"{a} is the largest one");
                if (b > c)
                {
                    Console.WriteLine($"{c} is smallest");
                }
                else
                {
                    Console.WriteLine($"{b} is smallest");
                }
            }
            else if (b >= c && b >= a)
            {
                Console.WriteLine($"{b} is the largest one");
                if (a > c)
                {
                    Console.WriteLine($"{c} is smallest");
                }
                else
                {
                    Console.WriteLine($"{c} is smallest");
                }
            }
            else
            {
                Console.WriteLine($"{c} is the largest one");
                if (b > a)
                {
                    Console.WriteLine($"{a} is smallest");
                }
                else
                {
                    Console.WriteLine($"{b} is smallest");
                }
            }
            Console.WriteLine("----Armstrong Check-----");
            Console.WriteLine($"{str}, Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0, r;
            int p = n;
            while (n > 0)
            {
                r = n % 10;
                s = s + (r * r * r);
                n = n / 10;

            }
            if (s == p)
            {
                Console.WriteLine($"{p} is armstrong");
            }
            else
            {
                Console.WriteLine($"{p} is not armstrong");
            }
            Console.WriteLine("----for Prime number----");
            Console.WriteLine("Enter a number");
            int q = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i <= q; i++)
            {
                if (q % i == 0)
                {
                    count++;
                }

            }
            if (count == 1)
            {
                Console.WriteLine($"{q} is prime number");
            }
            else
            {
                Console.WriteLine($"{q} is not a prime number");
            }
            Console.WriteLine("--------Convert Fahrenheit to Celsius--------");
            Console.WriteLine($"{str}, Enter the value of temperature in Fahrenheit");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in Fahrenheit is: " + temp);
            double Cel = (temp - 32) * 5 / 9;
            Console.WriteLine($"The temperature in Celsius is {Cel}");

        }
    }
}
