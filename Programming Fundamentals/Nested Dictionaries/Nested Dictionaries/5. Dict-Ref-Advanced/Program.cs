using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string keyToAdd = tokens[0];
                int first = -1;
                if (int.TryParse(tokens[1], out first))
                {
                    if (!dict.ContainsKey(keyToAdd))
                    {
                        dict.Add(keyToAdd, new List<int>());
                    }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        dict[keyToAdd].Add(int.Parse(tokens[i]));
                    }

                }
                else
                {
                    string inputKey = tokens[1];
                    if (dict.ContainsKey(inputKey))
                    {
                        dict[keyToAdd] = new List<int>(dict[inputKey]);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
            }
        }
    }
}
