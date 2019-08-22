using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Optimized_Banking_System
{
    class Bank
    {
        public string BankName { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        public Bank(string bankName, string accountName, decimal balance)
        {
            this.BankName = bankName;
            this.AccountName = accountName;
            this.Balance = balance;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Bank> bankData = new List<Bank>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string bankName = tokens[0];
                string accountName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                bankData.Add(new Bank(bankName, accountName, balance));

               


                input = Console.ReadLine();
            }

            foreach (var record in bankData.OrderByDescending(b => b.Balance).ThenBy(a => a.BankName.Length))
            {
                Console.WriteLine($"{record.AccountName} -> {record.Balance} ({record.BankName})");
            }
        }
    }
}
