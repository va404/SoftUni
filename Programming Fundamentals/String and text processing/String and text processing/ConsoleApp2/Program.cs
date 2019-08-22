using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);

            Console.WriteLine(string.Join(" ", nums));
            nums.RemoveAt(0);
            Console.WriteLine(string.Join(" ", nums));
            nums.RemoveAt(0);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
