using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Jan_Assignment__Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i; double d = 0;
            double sum = 0;
            double average = 0;
            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);

            }
            Array.Reverse(arr);
            Console.Write("\n");
            Console.WriteLine("array in descending order : ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n");
            Array.Sort(arr);
            Console.WriteLine("array in ascending order : ");
            foreach (int value in arr) { Console.Write(value + " "); }
            Console.Write("\n");
            Console.WriteLine("maximum element of array is = " + arr.Max());
            Console.WriteLine("minimum element of array is = " + arr.Min());

            Console.Write("\n");
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                average = sum / 10;


            }
            Console.WriteLine("total = " + sum);
            Console.WriteLine("average = " + average);


        }
    }
    
}
