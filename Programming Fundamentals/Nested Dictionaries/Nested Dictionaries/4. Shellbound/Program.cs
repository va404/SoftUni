using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<long>>();
            string[] input = Console.ReadLine().Split(' ');

            while (true)
            {
                if (input[0] == "Aggregate")
                {
                    break;
                }

                string region = input[0];
                long shellSize = long.Parse(input[1]);

                if (!dict.ContainsKey(region))
                {
                    dict.Add(region, new List<long>());
                }
                if (!dict[region].Contains(shellSize))
                {
                    dict[region].Add(shellSize);
                }
                

                input = Console.ReadLine().Split(' ');
            }
            foreach (var item in dict)
            {
                long sum = item.Value.Sum();
                long count = item.Value.Count;
                Console.WriteLine($"{item.Key} -> {string.Join(", ",item.Value)} ({sum-(sum/count)})");
            }

        }
    }
}
