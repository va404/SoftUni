using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Cardss
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex("([2-9]|10|[JQKA])[SDHC]");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            List<string> list = new List<string>(); ;
            
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
