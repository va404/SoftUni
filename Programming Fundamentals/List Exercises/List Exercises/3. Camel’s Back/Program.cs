using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());
            int rounds = 0;
            if (input.Count == camelBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", input)}");
            }
            else
            {
                while (input.Count != camelBackSize)
                {
                    rounds++;
                    input.Remove(input.First());
                    input.Remove(input.Last());
                    


                }
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", input)}");
            }



        }
    }
}
