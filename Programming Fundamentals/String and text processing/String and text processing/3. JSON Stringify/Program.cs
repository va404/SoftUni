using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder text = new StringBuilder();

            while (input != "stringify")
            {
                string[] tokens = input.Split(new string[] { " : ", " ->" }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string age = tokens[1];
                string[] grades = new string[] { };

                if (tokens.Length > 2)
                {
                    grades = tokens[2].Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                }
                if (text.Length != 0)
                {
                    text.Append(",");
                }

                text.Append("{");
                text.Append(string.Format("name:\"{0}\",age:{1},grades:[{2}]",
                    name, age, string.Join(", ", grades)));
                text.Append("}");

                input = Console.ReadLine();
            }
            Console.WriteLine($"[{text.ToString()}]");
        }
    }
}
