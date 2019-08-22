using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string bankName = tokens[0];
                string accName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!data.ContainsKey(bankName))
                {
                    data[bankName] = new Dictionary<string, decimal>();
                }
                if (!data[bankName].ContainsKey(accName))
                {
                    data[bankName].Add(accName, 0);
                }
                data[bankName][accName] += balance;


                input = Console.ReadLine();
            }

            foreach (var item in data.OrderByDescending(e => e.Value.Sum(p => p.Value)).ThenByDescending(e => e.Value.Max(p => p.Value)))
            {
                var bankName = item.Key;
                var accAndBalance = item.Value;
                foreach (var rec in accAndBalance.OrderByDescending(e => e.Value))
                {
                    var acc = rec.Key;
                   decimal balance = rec.Value;
                    Console.WriteLine($"{acc} -> {balance} ({bankName})");
                }
            }
        }
    }
}
