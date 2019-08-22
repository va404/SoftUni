using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(FirstDigit(input));
            string[] input = Console.ReadLine().Split(' ').ToArray();

            int num = input[0];
            Console.WriteLine(num);
            Console.WriteLine(FirstDigit(num));
        }
        static int FirstDigit(int num)
        {
            while (num >= 10)
            {
                num /= 10;
            }

            return num;
        }
    }
}