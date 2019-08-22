using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            foreach (var grapes in input)
            {
                int index = input.IndexOf(grapes);
                if (IsGreaterGrape(input))
                {
                    for (int i = 0; i < n; i++)
                    {

                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static bool IsGreaterGrape(List<int> input)
        {
            for (int i = 0; i < input.Count-1; i++)
            {
                if (input[i] > input[i + 1] && input[i] > input[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
