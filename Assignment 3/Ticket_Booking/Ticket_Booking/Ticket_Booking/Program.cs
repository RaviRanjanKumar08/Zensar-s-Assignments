using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    class TicketException : ApplicationException
    {
        public TicketException(string msg) : base(msg)
        {

        }
    }

    class Passenger
    {
        public string name;
        public int age;
        public void set()
        {
            name=Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("Passenger Name:" + name);
            Console.WriteLine("Passenger Age:" + age);
        }
        public void  TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets > 5)
            {
                throw (new TicketException("You cannot buy more than five tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while(n<=5)
            {
                Passenger p = new Passenger();
                Console.WriteLine("Enter Passenger Name and Age");
                p.set();
                p.show();
                Console.WriteLine("No. of tickets that booked:");
                int T = Convert.ToInt32(Console.ReadLine());

                try
                {
                    p.TicketBooking(T);
                }
                catch (TicketException te)
                {
                    Console.WriteLine(te.Message);
                }
                n++;
            }
        }
    }
}
