using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "stop the game")
            {
                string[] tokens = input.Split('|');
                string playerName = tokens[0];
                string teamName = tokens[1];
                int points = int.Parse(tokens[2]);

                if (!dict.ContainsKey(teamName))
                {
                    dict.Add(teamName, new Dictionary<string, int>());
                }
                if (dict[teamName].Count<3)
                {
                    dict[teamName].Add(playerName, points);
                }


                input = Console.ReadLine();
            }

            int teamPlace = 1;
            foreach (var team in dict.OrderByDescending(x => dict[x.Key].Values.Sum()).Where(x => dict[x.Key].Values.Count >= 3))
            {

                var playersAndScores = team.Value;


                Console.WriteLine($"{teamPlace}. {team.Key}; Players:");
                foreach (var item in playersAndScores.OrderByDescending(x => x.Value).Take(3))
                {

                    Console.WriteLine($"###{item.Key}: {item.Value}");
                }
                teamPlace++;
            }
        }
    }
}
