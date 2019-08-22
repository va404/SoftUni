using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "ready")
                {
                    break;
                }
                string[] tokens = input.Split(':');
                string city = tokens[0];
                string vac = tokens[1];
                string[] vehicles = vac.Split(',');


                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, new Dictionary<string, int>());
                }
                else
                {

                }
                foreach (string item in vehicles)
                {
                    string[] veh = item.Split('-');
                    string vehicle = veh[0];
                    int capacity = int.Parse(veh[1]);

                    Dictionary<string, int> values = dict[city];

                    if (!values.ContainsKey(vehicle))
                    {
                        values.Add(vehicle, capacity);
                    }

                    values[vehicle] = capacity;


                }

                input = Console.ReadLine();

            }
            string travelInput = Console.ReadLine();
            while (true)
            {
                if (travelInput == "travel time!")
                {
                    break;
                }

                string[] tokens = travelInput.Split(' ');
                string travelTo = tokens[0];
                int passengers = int.Parse(tokens[1]);
                int sum = 0;
                foreach (var item in dict)
                {
                    Dictionary<string, int> values = item.Value;


                    if (item.Key==travelTo)
                    {
                        sum = item.Value.Values.Sum();

                        if (sum >= passengers)
                        {
                            Console.WriteLine($"{travelTo} -> all {passengers} accommodated");

                        }
                        else
                        {
                            Console.WriteLine($"{travelTo} -> all except {passengers - sum} accommodated");

                        }
                    }

                }

                travelInput = Console.ReadLine();
            }

        }
    }
}

