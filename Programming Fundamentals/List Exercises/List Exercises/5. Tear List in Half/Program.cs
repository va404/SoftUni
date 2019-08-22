using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            int firstNum = 0;
            int secondNum = 0;
            int index = 0;
            for (int i = input.Count / 2; i < input.Count; i++)
            {
                firstNum = input[i] / 10;
                secondNum = input[i] % 10;
                newList.Add(firstNum);
                newList.Add(input[index]);
                newList.Add(secondNum);
                index += 1;
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}