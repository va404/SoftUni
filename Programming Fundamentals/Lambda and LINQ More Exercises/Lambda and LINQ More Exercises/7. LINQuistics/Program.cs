using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LINQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "exit")
            {

                string[] tokens = input.Split(new string[] { ".", "()" }, StringSplitOptions.RemoveEmptyEntries);

                string collectionName = tokens[0];
                string[] methods = tokens.Skip(1).Take(10).ToArray();

                if (!data.ContainsKey(collectionName))
                {
                    data.Add(collectionName, new List<string>());
                }
                
                    data[collectionName].AddRange(methods);
                
                

                


                input = Console.ReadLine();

            }
            

            foreach (var item in data)
            {
                
                Console.WriteLine($"{item.Key} -- {string.Join(" ", item.Value)}");
            }
        }
    }
}
