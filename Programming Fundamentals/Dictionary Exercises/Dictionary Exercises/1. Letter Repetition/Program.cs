using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

           string input = Console.ReadLine();

            var chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!dict.ContainsKey(chars[i]))
                {
                    dict.Add(chars[i], 0);
                }
                dict[chars[i]]++;
            }
            foreach (char ch in dict.Keys)
            {
                Console.WriteLine($"{ch} -> {dict[ch]}");
            }
        }
    }
}
