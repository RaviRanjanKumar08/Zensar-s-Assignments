using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cricket_IPL
{
    class Cricket
    {
        public void PointsCalculation(int[] no_of_matches)
        {
            for(int i=1; i<no_of_matches.Length; i++)
            {
                no_of_matches[i] *= 2;
            }

        }
        public  void DisplayPoints(int []no_of_matches)
        {
           Console.WriteLine("The point score by teams are:");
           for(int i=0; i<no_of_matches.Length; i++)
           {
                Console.WriteLine(no_of_matches [i]);
           }
        }
        public int DisplaySum(int[] no_of_matches)
        {
            int sum = 0;
            for (int i = 0; i < no_of_matches.Length; i++)
            {
                sum = sum + no_of_matches[i];
            }
            return sum;
        }
        public double DisplayAvg(int[]no_of_matches)
        {
            double avg;
            avg = DisplaySum(no_of_matches) / 8.0;
            return avg;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[8];
            Console.WriteLine("Enter the Matches played by Teams:");
            for (int i = 1; i < m.Length; i++)
            {
                Console.WriteLine("Enter the Matches played by Team{0}:", i);
                m[i]=Convert.ToInt32(Console.ReadLine());
            }
            Cricket C = new Cricket();
            C.PointsCalculation(m);
            C.DisplayPoints(m);
            int s=C.DisplaySum(m);
            double a=C.DisplayAvg(m);
            Console.WriteLine("The Sum and Average of points scored by teams are: {0} and {1}", s, a);
        }
    }
}
