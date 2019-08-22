using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int i = input.Length - 1; i > 0; i--)
            {
                if (input[i]==input[i-1])
                {
                    if (input[i-1]==input[i-2])
                    {
                        Console.WriteLine($"{input[i]} {input[i]} {input[i]}");
                        break;
                    }
                }
            }

            //var count = 1;
            //for (int i = input.Length - 1; i > 0; i--)
            //{
            //    if (input[i] == input[i - 1])
            //    {
            //        count++;

            //        if (count == 3)
            //        {
            //            Console.WriteLine("{0} {1} {2}",input[i], input[i], input[i]);
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        count = 1;
            //    }
            //}
        }
    }
}
