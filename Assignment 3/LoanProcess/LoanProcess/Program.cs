using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProcess
{
    class LoanException : ApplicationException
    {
        public LoanException(string msg) : base(msg)
        {

        }
    }
    class LoanProcess
    {
        public int Loan_No;
        public string c_name;
        public int amount;
        public double emi_amount;
        public int bal;

        public void calculate_EMI(int amount)
        {
            emi_amount = amount * 0.13 * 3;
        }
        public void CheckBalance(int bal)
        {
            if (bal < emi_amount)
            {
                throw (new LoanException("Not Sufficient Balance to Repay Loan"));
            }
            else
            {
                Console.WriteLine("Congratulation! Loan Process Successful");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Loan Amount:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Balance:");
            int b= Convert.ToInt32(Console.ReadLine()); 
            LoanProcess lp = new LoanProcess();
            lp.calculate_EMI(a);
            lp.CheckBalance(b);
        }
    }
}
