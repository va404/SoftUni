using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2==1)
                {
                    if (arr[i]%2==1 || arr[i]%2==-1)
                    {
                        Console.WriteLine($"Index {i} -> {arr[i]}");
                    }
                    
                }
            }
            
        }
    }
}
