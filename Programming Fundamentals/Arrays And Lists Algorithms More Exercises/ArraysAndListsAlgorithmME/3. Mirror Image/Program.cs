using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();


            while (command != "Print")
            {
                int num = int.Parse(command);

                for (int i = 0; i < num / 2; i++)
                {
                    string temp = input[i];
                    input[i] = input[num - 1 - i];
                    input[num - i - 1] = temp;

                }
                Array.Reverse(input);
                for (int i = 0; i < (input.Length-1-num)/2; i++)
                {
                    string temp = input[i];
                    input[i] = input[input.Length - 2 - num - i];
                    input[input.Length - 2 - num - i] = temp;
                }
                Array.Reverse(input);
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
