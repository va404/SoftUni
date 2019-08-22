using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> newList = new List<int>();
            newList.Add(list1[0]);
            newList.Add(list1.Last());
            list1.Remove(list1.First());
            list1.Remove(list1.Last());
            list1.Reverse();
            for (int i = list1.Count - 1; i >= 0; i--)
            {
                newList.Insert(1, list1[i]);
            }

            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
