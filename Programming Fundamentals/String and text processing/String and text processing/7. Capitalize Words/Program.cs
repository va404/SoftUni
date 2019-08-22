using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = (3, 5, 6, 7, 8);
            Console.WriteLine(string.Join(" ", nums));
            nums.RemoveAt(0);
            Console.WriteLine(string.Join(" ", nums));
            nums.RemoveAt(0);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
