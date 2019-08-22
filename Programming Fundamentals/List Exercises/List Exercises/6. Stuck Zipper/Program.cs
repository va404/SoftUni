using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            int smallestCountOfDigits = CountOfDigits(Math.Min(list1.Min(),list2.Min()));
            foreach (var item in list1.ToList())
            {
                if (CountOfDigits(item) > smallestCountOfDigits)
                {
                    list1.Remove(item);
                }
            }
            foreach (var item in list2.ToList())
            {
                if (CountOfDigits(item) > smallestCountOfDigits)
                {
                    list2.Remove(item);
                }
            }
            int index = 1;
            for (int i = 0; i < list1.Count; i++)
            {
                if (index <= list2.Count)
                {
                    list2.Insert(index, list1[i]);

                }
                else
                {
                    list2.Add(list1[i]);
                }
                index += 2;
            }
            Console.Write(string.Join(" ", list2));
            Console.WriteLine();

        }

        private static int CountOfDigits(int num)
        {
            int counter = 0;
            while (num != 0)
            {
                num /= 10;
                counter++;
            }
            return counter;
        }
    }
}
