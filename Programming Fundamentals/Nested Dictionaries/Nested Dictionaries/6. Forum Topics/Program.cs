using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "filter")
                {
                    break;
                }
                string[] tokens = input.Split(", ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string topic = tokens[0];


                if (!dict.ContainsKey(topic))
                {
                    dict[topic] = new List<string>();
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    if (!dict[topic].Contains(tokens[i]))
                    {
                        dict[topic].Add(tokens[i]);
                    }
                }

                input = Console.ReadLine();
            }



            var filterBy = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var pair in dict)
            {
                bool toPrint = false;

                for (int i = 0; i < filterBy.Length; i++)
                {
                    if (pair.Value.Contains(filterBy[i]))
                    {
                        toPrint = true;
                    }
                    else
                    {
                        toPrint = false;
                        break;
                    }
                }

                if (toPrint)
                {
                    Console.WriteLine($"{pair.Key} | #{string.Join(", #", pair.Value)}");
                }

            }

        }
    }
}
