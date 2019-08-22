using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "lambada")
            {
                string[] tokens = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "dance")
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        var crrObject = data.ElementAt(i);
                        var valueList = crrObject.Value.Split('.').ToList();
                        string key = crrObject.Key;
                        string value = crrObject.Value;
                        data[key] = valueList[0] + "." + value;
                    }
                }
                else
                {
                    string key = tokens[0];
                    string value = tokens[1];
                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, string.Empty);
                    }
                    data[key] = value;
                }

                input = Console.ReadLine();
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}