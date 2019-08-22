using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 20, 50, 30 };
            Console.WriteLine(list.Sum()-(list.Sum()/list.Count));
            //var dict = new Dictionary<string, List<string>>();
            //string searchedKey = Console.ReadLine();
            //string searchedValue = Console.ReadLine();
            //int lines = int.Parse(Console.ReadLine());

            //for (int i = 0; i < lines; i++)
            //{
            //    string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
            //    string inputKey = input[0];
            //    string[] inputValues = input[1].Split(';');

            //    if (!dict.ContainsKey(inputKey))
            //    {
            //        dict.Add(inputKey, new List<string>());
            //    }
            //    foreach (var item in inputValues)
            //    {
            //        dict[inputKey].Add(item);
            //    }
            //}

            //foreach (var pair in dict)
            //{

            //    if (pair.Key.Contains(searchedKey))
            //    {
            //        Console.WriteLine($"{pair.Key}:");
            //        List<string> values = pair.Value;
            //        foreach (var item in values)
            //        {
            //            if (item.Contains(searchedValue))
            //            {
            //                Console.WriteLine($"-{string.Join("", item)}");
            //            }
            //        }
            //    }
            //}

        }
    }
}

