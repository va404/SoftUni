using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();

            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                double price = double.Parse(tokens[1]);

                if (!dict.ContainsKey(product))
                {
                    dict.Add(product, price);
                }
                else
                {
                    if (dict[product] > price)
                    {
                        dict[product] = price;
                    }
                }


                input = Console.ReadLine();
            }
            double sum = dict.Values.Sum();
            if (budget >= sum)
            {
                foreach (var products in dict.OrderByDescending(v => v.Value).ThenBy(k => k.Key.Length))
                {
                    Console.WriteLine($"{products.Key} costs {products.Value:f2}");
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
        }
    }
}
