using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int[] intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //char[] charArr = new char[intArr.Length];




            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    if (intArr[i] % 2 == 0)
            //    {   
            //       charArr[i] = (char)(input[i] - intArr[i]);


            //    }
            //    else
            //    {
            //        charArr[i] = (char)(input[i] + intArr[i]);
            //    }
            //}
            //Console.WriteLine(string.Join("",charArr));
            int num = int.Parse(Console.ReadLine());

          
            
            Console.WriteLine(SumOfDigits(num));
            Console.WriteLine($"{minutes:00} : {seconds:00}");
        }

        static int SumOfDigits(int num)
        {
            var sum = 0;
            do
            {
                sum += num % 10;
                num /= 10;

            } while (num != 0);
            return sum;
        }
    }
}
