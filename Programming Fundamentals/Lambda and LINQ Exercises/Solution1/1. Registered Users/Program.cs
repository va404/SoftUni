using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Registered_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var registers = new Dictionary<string, DateTime>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string format = "dd/MM/yyyy";
                DateTime date = DateTime.ParseExact(tokens[1], format, null);
               
                if (!registers.ContainsKey(user))
                {
                    registers.Add(user, new DateTime());
                }
                registers[user] = date;


                input = Console.ReadLine();
            }

            registers = registers.Reverse().OrderBy(v => v.Value).Take(5).ToDictionary(k => k.Key,v => v.Value);

            foreach (var item in registers.OrderByDescending(v => v.Value))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
