using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            var phonebook = new SortedDictionary<string, string>();
            bool listAll = false;
            while (input[0] != "END")
            {
                var firstCase = input[0];

                

                
                switch (firstCase)
                {

                    case "A":
                        var phoneNumber = input[2];
                        if (phonebook.ContainsKey(input[1]))
                        {
                            phonebook[input[1]] = string.Empty;
                            phonebook[input[1]] = phoneNumber;
                        }
                        else
                        {
                            phonebook.Add(input[1], phoneNumber);
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phonebook)
                        {
                            Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                        }
                        break;
                }
              
                input = Console.ReadLine().Split();
            }
        }
    }
}
