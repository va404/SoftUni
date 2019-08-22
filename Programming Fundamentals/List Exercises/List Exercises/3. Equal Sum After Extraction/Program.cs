using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list2.Count; i++)
            {
                foreach (var num in list1)
                {
                    if (list2.Contains(num))
                    {
                        list2.RemoveAll(a => a == num);
                    }
                }
            }
            if (list1.Sum() == list2.Sum())
            {
                Console.WriteLine($"Yes. Sum: {list1.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(list1.Sum()-list2.Sum())}");
            }
           
        }
    }
}
