using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<KeyValuePair<string, int>>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string nameOfThePerson = tokens[0];
                string camperModel = tokens[1];
                int nightsCount = int.Parse(tokens[2]);

                if (!data.ContainsKey(nameOfThePerson))
                {
                    data.Add(nameOfThePerson, new List<KeyValuePair<string, int>>());
                }
                if (!data[nameOfThePerson].Any(n => n.Key == camperModel))
                {
                    data[nameOfThePerson].Add(new KeyValuePair<string, int>(camperModel, nightsCount));
                }
                

                input = Console.ReadLine();
            }

            foreach (var item in data.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key.Length))
            {
                string key = item.Key;
                var kvp = item.Value;

                Console.WriteLine($"{key}: {kvp.Count}");
                foreach (var pair in kvp)
                {
                    Console.WriteLine($"***{pair.Key}");
                }
                Console.WriteLine($"Total stay: {kvp.Sum(n => n.Value)} nights");
            }
        }
    }
}
