using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Info
{
    internal class Program
    {
        struct employee
        {
            public string eName;
            public dob Date;
        }
        struct dob
        {
            public int day;
            public int month;
            public int year;
        }
        static void Main(string[] args)
        {
            int dd = 0, mm = 00, yy = 00;
            int total=2;
            Console.WriteLine("Enter the details of Employee");
            employee[] emp = new employee[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Enter day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.day = dd;

                Console.Write("Enter month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.month = mm;

                Console.Write("Enter year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.year = yy;
            }
        }
    }

}  
    

