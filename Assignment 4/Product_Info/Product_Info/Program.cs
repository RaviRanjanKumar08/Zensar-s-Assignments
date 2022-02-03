using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Info
{
    public class Test<T>
    {
        T[] obj = new T[10];
        int count = 0;
        public void Add(T item)
        {
            if (count + 1 < 10)
            {
                obj[count] = item;

            }
            count++;
        }
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test<int> obj = new Test<int>();
            Console.WriteLine("Enter the product details:");
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            obj.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Added Item is:");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(obj[i]+" ");
            }

        }
    }
}
