using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_interface
{
    internal class program
    {

        interface IStudent
        {

            void show();
        }
        class dayScholar : IStudent
        {

            public int Id;
            public string Name;
            public dayScholar(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public void ShowDetails()
            {
                Console.WriteLine("Day Scholar Student Id: " + Id);
                Console.WriteLine("Day Scholar Student Name: " + Name);
            }
        }
        class resident : IStudent
        {
            public int Id;
            public string Name;
            public resident(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public void Show()
            {
                Console.WriteLine("Resident Student Id: " + Id);
                Console.WriteLine("Resident Student Name: " + Name);
            }
        }
       
            public static void Main(string[] args)
            {
                int Id;
                string Name;
                Console.WriteLine("Enter the name of day scholar student:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the Id of day scholar student:");
                Id = Convert.ToInt32(Console.ReadLine());
                dayScholar ds = new dayScholar(Id, Name);
                ds.ShowDetails();
                Console.WriteLine("Enter the name of resident student:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the Id of day resident student:");
                Id = Convert.ToInt32(Console.ReadLine());
                resident res = new resident(Id, Name);
                res.Show();
            }
        
    }
}
