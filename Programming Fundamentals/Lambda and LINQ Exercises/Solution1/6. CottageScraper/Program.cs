using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var trees =new  List<KeyValuePair<string,int>>();

            string input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string tree = tokens[0];
                int treeHeight = int.Parse(tokens[1]);

                trees.Add(new KeyValuePair<string, int>(tree,treeHeight));

                input = Console.ReadLine();
            }

            string neededTree = Console.ReadLine();
            int neededHeight = int.Parse(Console.ReadLine());
         
            double pricePerMeter = Math.Round(trees.Average(x=>x.Value),2);

            double usedTreesPrice = Math.Round(trees.Where(x=> x.Key==neededTree && x.Value>= neededHeight).Sum(d =>d.Value)* pricePerMeter, 2);
            double unusedTotal = Math.Round((trees.Where(x => x.Key != neededTree || x.Value < neededHeight).Sum(d => d.Value) * pricePerMeter)*0.25, 2);
            double total = Math.Round(usedTreesPrice + unusedTotal,2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedTreesPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedTotal:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${total:f2}");

        }
    }
}
