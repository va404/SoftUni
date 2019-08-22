using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            double p = double.Parse(Console.ReadLine());

            double[] arrDouble = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrDouble[i] = double.Parse(arr[i]);
            }
            for (int i = 0; i < arrDouble.Length; i++)
            {
                arrDouble[i] *= p;
            }
            for (int i = 0; i <arrDouble.Length; i++)
            {
                Console.Write(arrDouble[i]+ " ");
            }
        }
    }
}
