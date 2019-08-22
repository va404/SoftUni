using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, string>>();
            var flattenedDict = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {


                string[] tokens = input.Split(' ');
                if (tokens[0] == "flatten")
                {
                    string flattenKey = tokens[1];

                    foreach (var item in dict)
                    {
                        string key = item.Key;
                        var secondValues = item.Value;
                        if (key==flattenKey)
                        {
                            foreach (var secItem in secondValues)
                            {
                                string flatten = secItem.Key + secItem.Value;
                                if (!flattenedDict.ContainsKey(key))
                                {
                                    flattenedDict.Add(key, new List<string>());

                                }
                                flattenedDict[key].Add(flatten);
                            }
                        }
                    }
                    dict[flattenKey] = new Dictionary<string, string>();

                }
                else
                {
                    string firstKey = tokens[0];
                    string secondKey = tokens[1];
                    string value = tokens[2];

                    if (!dict.ContainsKey(firstKey))
                    {
                        dict.Add(firstKey, new Dictionary<string, string>());
                    }
                    dict[firstKey][secondKey] = value;

                }


                input = Console.ReadLine();
            }

            foreach (var item in dict.OrderByDescending(x => x.Key.Length))
            {
                var secDict = item.Value;
                Console.WriteLine($"{item.Key}");
                int numOrder = 1;
                foreach (var item2 in secDict.OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{numOrder}. {item2.Key} - {item2.Value}");
                    numOrder++;
                }
                if (flattenedDict.ContainsKey(item.Key))
                {
                    foreach (var flattenItem in flattenedDict[item.Key])
                    {
                        Console.WriteLine($"{numOrder}. {flattenItem}");
                        numOrder++;
                    }
                }
            }
        }
    }
}
