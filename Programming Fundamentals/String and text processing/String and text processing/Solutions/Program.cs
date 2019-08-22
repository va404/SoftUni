using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solutions
{

}
class Program
{

    static void Main(string[] args)
    {
        var activityDict = new Dictionary<string, int>();
        var armada = new Dictionary<string, Dictionary<string, int>>();


        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            string[] input = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" },
                        StringSplitOptions.RemoveEmptyEntries);
            int activity = int.Parse(input[0]);
            string legionName = input[1];
            string soldierType = input[2];
            int soldierCount = int.Parse(input[3]);


            if (!armada.ContainsKey(legionName))
            {
                armada[legionName] = new Dictionary<string, int>();
                activityDict[legionName] = activity;
            }
            if (!armada[legionName].ContainsKey(soldierType))
            {
                armada[legionName].Add(soldierType, 0);
            }
            if (activityDict[legionName] < activity)
            {
                activityDict[legionName] = activity;
            }
            armada[legionName][soldierType] += soldierCount;

            n--;
        }

        //In the first case, you must print all legions, and the count of soldiers they have from the given soldier type,
        //    who’s last activity is LOWER than the given activity.The legions must be printed
        //    in descending order by soldier count.
        string[] printInput = Console.ReadLine().Split('\\').ToArray();
        if (printInput.Length > 1)
        {
            int activity = int.Parse(printInput[0]);
            string type = printInput[1];
            foreach (var item in armada.Where(legion => legion.Value.ContainsKey(type)).OrderByDescending(legion => legion.Value[type]))
            {
                if (activityDict[item.Key] < activity)
                {
                    Console.WriteLine($"{item.Key} -> {armada[item.Key][type]}");
                }
            }

        }
        else
        {
            string type = printInput[0];

            foreach (var item in activityDict.OrderByDescending(l => l.Value))
            {
                if (armada[item.Key].ContainsKey(type))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
            }
        }

    }

}

