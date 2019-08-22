using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, double>();
            List<string> productsToBuy = new List<string>();
            string input = Console.ReadLine();
            var spendedMoneyData = new Dictionary<string, List<string>>();
            while (input != "Shop is open")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                
                if (!data.ContainsKey(product))
                {
                    data.Add(product, price);
                }

                input = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();

            while (secondInput != "Print")
            {
                if (secondInput != "Discount")
                {
                    string[] tokens = secondInput.Split(new string[] { ", ", ": " }, StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    productsToBuy = tokens.Skip(1).ToList();

                    if (!spendedMoneyData.ContainsKey(name))
                    {
                        spendedMoneyData.Add(name, new List<string>());
                    }
                    for (int i = 0; i < productsToBuy.Count; i++)
                    {
                        if (data.ContainsKey(productsToBuy[i]))
                        {
                            spendedMoneyData[name].Add(productsToBuy[i]);
                        }
                    }

                }
                else
                {
                    var discounted = data.OrderByDescending(n => n.Value).Take(3)
                        .Select(n => new KeyValuePair<string, double>(n.Key, n.Value * 0.9));

                    foreach (var item in discounted)
                    {
                        string key = item.Key;

                        data[key] = item.Value;
                    }
                }
                secondInput = Console.ReadLine();
            }
            var topSpend = spendedMoneyData.OrderByDescending(n => n.Value.Sum(p => data[p])).First();
            string topSpenderName = topSpend.Key;
            List<string> productsBought = topSpend.Value;

            Console.WriteLine($"Biggest spender: {topSpenderName}");
            Console.WriteLine($"^Products bought:");
            var products = productsBought.Distinct().OrderByDescending(p => data[p]);
            foreach (var item in products)
            {
                Console.WriteLine($"^^^{item}: {data[item]:f2} ");
            }
            Console.WriteLine($"Total: {productsBought.Sum(p => data[p]):f2}");
        }
    }
}
