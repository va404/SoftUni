using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameAndAge = new Dictionary<string, int>();
            Dictionary<string, double> nameAndSalary = new Dictionary<string, double>();
            Dictionary<string, string> nameAndPosition = new Dictionary<string, string>();

            

            string input = Console.ReadLine();

            while (input != "filter base")
            {
                int age = 0;
                double salary = 0;
                string[] tokens = input.Split(' ');
                string name = tokens[0];
                var toParse = tokens[2];
                if (int.TryParse(toParse, out age))
                {
                    nameAndAge.Add(name, age);
                }
                else if (double.TryParse(toParse, out salary))
                {
                    nameAndSalary.Add(name, salary);
                }
                else
                {
                    nameAndPosition.Add(name, tokens[2]);
                }

                input = Console.ReadLine();
            }
            nameAndAge.OrderBy(n => nameAndAge.Values);
            nameAndSalary.OrderBy(n => nameAndSalary.Values);
            nameAndPosition.OrderBy(w => nameAndPosition.Values);

            string filterBy = Console.ReadLine();
            string separator = "====================";
            switch (filterBy)
            {
                case "Age":
                    foreach (var item in nameAndAge)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Age: {item.Value}");
                        Console.WriteLine(separator);
                    }
                    break;
                case "Salary":
                    foreach (var item in nameAndSalary)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Salary: {item.Value:f2}");
                        Console.WriteLine(separator);
                    }
                    break;
                case "Position":
                    foreach (var item in nameAndPosition)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Position: {item.Value}");
                        Console.WriteLine(separator);
                    }
                    break;
            }

        }
    }
}
