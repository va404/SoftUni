using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string separator = Console.ReadLine();

            string[] tokens = input.Split(new string[] { separator }, StringSplitOptions.None);
            Console.WriteLine($"[{string.Join(", ",tokens)}]");

        }
    }
}
