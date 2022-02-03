using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Fare
{
    class Program
    {
        static void Main()
        {
            int Fare = 500;
            string Name;
            int Age;
            Console.WriteLine("Enter The Name of Citizen: ");
            Name = Console.ReadLine();
            CalculateConcession.Concession cc = new CalculateConcession.Concession();
            cc.CalculateConcession1();
        }
    }
}

namespace CalculateConcession
{
    public class Concession
    {
        int Fare = 500;
        int age;
        public void CalculateConcession1()
        {
            Console.WriteLine("Enter The Citizen's Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 5)
            {
                Console.WriteLine("Little Champs-Free Tickets:");
            }
            else if (age > 60)
            {
                double CalculatedFare = Fare * 0.03;
                double Fare = Fare - CalculatedFare;
                Console.WriteLine("Senior Citizen has to pay:Rs.{0}", Fare);
            }
            else
            {
                Console.WriteLine("Ticked Booked with a payment of Rs.{0}", Fare);
            }
        }
    }
}

      