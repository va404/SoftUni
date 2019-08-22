using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int toSkip = input[0];
            int toTake = input[1];
            inputArr = inputArr.Where(e => e >= 65 && e <= 90).Skip(toSkip).Take(toTake).ToArray();

            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write(string.Join("",(char)inputArr[i]));
            }
            Console.WriteLine();
        }
    }
}
