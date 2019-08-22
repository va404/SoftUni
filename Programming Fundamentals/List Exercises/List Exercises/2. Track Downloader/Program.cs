using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            int number=0;
            while (command != "end")
            {
                 number = command[0];
                Console.WriteLine(number);
                command = Console.ReadLine();
            }
           
        }
    }
}