using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            initialList.Sort();
            initialList.RemoveAll(e => e < initialList.Average());
            

            switch (command)
            {
                case "Min":
                    Console.WriteLine(initialList.Min());
                    break;
                case "Max":
                    Console.WriteLine(initialList.Max());
                    break;
                case "All":
                    Console.WriteLine(string.Join(" ", initialList));
                    break;
            }
        }
    }
}
