using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] rotated = new string[arr.Length];

            string lastIndex = arr.Last();

            for (int i = 0; i < arr.Length-1; i++)
            {
                rotated[i+1] = arr[i];
                rotated[0] = lastIndex;
            }
            Console.WriteLine(string.Join(" ",rotated));
        }
    }
}
