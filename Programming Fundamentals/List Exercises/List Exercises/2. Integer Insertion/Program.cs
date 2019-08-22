using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
           
          
            while (command[0] != "end")
            {
                int num = int.Parse(command[0]);
                int index = FirstDigit(num);
                input.Insert(index, num);


                command = Console.ReadLine().Split(' ').ToArray(); 
            }
            Console.WriteLine(string.Join(" ", input));
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
