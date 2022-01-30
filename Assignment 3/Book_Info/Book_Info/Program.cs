using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Book_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Console.WriteLine("Enter the information of book 1 and name of author:");
            string str1=Console.ReadLine();
            string str2=Console.ReadLine();
            Console.WriteLine("Enter the information of book 2 and name of author:");
            string str3=Console.ReadLine();
            string str4=Console.ReadLine();
            ht.Add(str1, str2);
            ht.Add(str3, str4); 
            foreach(DictionaryEntry item in ht)
            {
                
                Console.WriteLine("Title:{0}, Author: {1}", item.Key, item.Value);
            }
            //for ex- Book 1= Basic     Name = S.TROELSTRA
            //        Book 2= C+        Name = G.RTRTG



        }
    }
}
