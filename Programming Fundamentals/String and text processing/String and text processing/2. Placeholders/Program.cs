using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string text = tokens[0];
                string[] parameters = tokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < parameters.Length; i++)
                {
                    string parameter = parameters[i];
                    string placeHolder = "{" + i + "}";

                    text = text.Replace(placeHolder, parameter);

                }

                Console.WriteLine(text);
                input = Console.ReadLine();
            }
        }
    }
}
