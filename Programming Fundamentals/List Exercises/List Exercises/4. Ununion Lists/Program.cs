using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                foreach (var num in input)
                {
                    if (primalList.Contains(num))
                    {
                        primalList.RemoveAll(a => a == num);
                    }
                    else
                    {
                        primalList.Add(num);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
