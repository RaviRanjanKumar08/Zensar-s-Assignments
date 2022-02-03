using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stationary_Info
{
    class Product
    {
        static void Main()
        {
            SortedList<double, string> prod = new SortedList<double, string>();
            Console.WriteLine("Enter Details of 10 Products:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter product {0} Price and Product {1} Name", i + 1, i + 1);
                double pr = Convert.ToDouble(Console.ReadLine());
                string str = Console.ReadLine();
                prod.Add(pr, str);
            }
            Console.WriteLine("Product Details after sort:");
            foreach (KeyValuePair<double, string> KV in prod)
            {
                Console.WriteLine("Product Name: {1} \t ProductName: {0}", KV.Key, KV.Value);
            }
        }

    }

}
