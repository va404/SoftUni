using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0];
                string value = tokens[1];
                
               
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, string.Empty);
                }
                dict[key] = value;


                input = Console.ReadLine();
            }
            string defaultValue = Console.ReadLine();


            foreach (var item in dict.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length))
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
            foreach (var item in dict.Where(x => x.Value == "null").OrderByDescending(x => x.Value.Length))
            {
                Console.WriteLine($"{item.Key} <-> {defaultValue}");
            }
        }
    }
}
