using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_account
{
        enum Transaction { Depo, Withdrawl };
        class accounts
        {
            private int n, amount, bal;
            private string name, type;
            private char trans;
            public accounts(int n, string name, string type, int bal)
            {
                this.n = n;
                this.name = name;
                this.type = type;
                this.bal = bal;
            }
            public void setType(Transaction trans)
            {
                if (trans == Transaction.Depo) 
                    this.trans = 'D';
                else
                    this.trans = 'W';
            }
            public char getType()
            {
                return this.trans;
            }
            public void showData()
            {
                Console.WriteLine("Account No: " + n);
                Console.WriteLine("Customer Name: " + name);
                Console.WriteLine("Transaction Type: " + trans);
                Console.WriteLine("Amount(to be credit/debit): " + amount);
                Console.WriteLine("Balance: " + bal);
            }
            public void credit(int amount)
            {
                this.amount = amount;
                this.bal = bal + amount;
            }
            public void debit(int amount)
            {
                this.amount = amount;
                if (amount > bal)
                {
                    Console.WriteLine("Sorry! Transaction has failed due to low balance");
                    return;
                }
                this.bal = bal - amount;
            }
        }
        class program 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the name: ");
                string str = Console.ReadLine();
                Console.WriteLine("Enter the type of account: ");
                string type = Console.ReadLine();
                Console.WriteLine("Enter the account number: ");
                int accno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the balance: ");
                int bal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the transaction type: ");
                char transType = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the amount(Credit/Debit) ");
                int amount = Convert.ToInt32(Console.ReadLine());
                accounts a = new accounts(accno, str, type, bal);
                if (transType == 'D')
                    a.setType(Transaction.Depo);
                else 
                    a.setType(Transaction.Withdrawl);
                char temp = a.getType();
                if (temp == 'D') 
                    a.credit(amount);
                if (temp == 'W') 
                    a.debit(amount);
                a.showData();
            }
        }

       
}
