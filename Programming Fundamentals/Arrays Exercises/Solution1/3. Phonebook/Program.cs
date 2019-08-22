using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string commands = Console.ReadLine();

            while (commands != "done")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                        if (commands == names[i])
                        {
                            Console.WriteLine($"{names[i]} -> {numbers[i]}");
                            break;

                        }
                }
                commands = Console.ReadLine();
            }
        }
    }
}
