using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(' ');
            
           
            while (input[0] != "end")
            {
                int n = -1;
                if (int.TryParse(input[2], out n))
                {
                    dict[input[0]] = n;
                   
                   
                }
                else
                {
                    if (dict.ContainsKey(input[2]))
                    {
                        dict.TryGetValue(input[2], out n);
                        dict[input[0]] = n;
                    }
                }


                input = Console.ReadLine().Split(' ');
            }


            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
