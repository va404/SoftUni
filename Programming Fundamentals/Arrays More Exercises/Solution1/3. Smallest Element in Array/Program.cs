using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int[] numbers = new int[arr.Length];

            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }
            num = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                
                if (numbers[i] < num)
                {
                    num = numbers[i];
                }
               


            }
            Console.WriteLine(num);
        }
    }
}
