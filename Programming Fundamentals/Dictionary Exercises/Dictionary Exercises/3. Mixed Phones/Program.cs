using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> dict = new SortedDictionary<string, long>();

            string[] input = Console.ReadLine().Split(' ');
            long num = 0;

            while (input[0] != "Over")
            {
                bool isNumeric = long.TryParse(input[0], out num);
                if (isNumeric)
                {

                    dict[input[2]] = long.Parse(input[0]);

                }
                else
                {
                    dict[input[0]] = long.Parse(input[2]);
                }


                input = Console.ReadLine().Split(' ');
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }

    }
}