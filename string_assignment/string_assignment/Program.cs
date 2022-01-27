using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_assignment
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter string:");
                string str = Console.ReadLine();
                Console.Write("The length of string is:");
                Console.WriteLine(str.Length);
                Console.Write("The reverse of string is:");
                char[] chars = str.ToCharArray();
                char[] result = new char[chars.Length];
                for (int i = 0, j = str.Length - 1; i < j; i++, j--)
                {
                    char c = chars[i];
                    chars[i] = chars[j];
                    chars[j] = c;
                }
                Console.WriteLine(chars);
                Console.WriteLine("For string Comparision:");
                Console.WriteLine("Enter another string:");
                string str2 = Console.ReadLine();
                if (string.Equals(str2, str))
                {
                    Console.WriteLine("String have same values");
                }
                else
                {
                    Console.WriteLine("String haven't the same values");
                }
            }
        
    }
}
