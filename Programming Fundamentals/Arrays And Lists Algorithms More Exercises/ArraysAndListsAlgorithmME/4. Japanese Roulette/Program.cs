using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> players = Console.ReadLine().Split(' ').ToList();

            bool isDead = false;
            int indexOfBullet = 0;

            for (int i = 0; i < cylinder.Count; i++)
            {
                if (cylinder[i] == 1)
                {
                    indexOfBullet = i;
                    break;
                }
            }
            for (int i = 0; i < players.Count; i++)
            {
                string[] commands = players[i].Split(',');
                int strength = int.Parse(commands[0]);
                string direction = commands[1];

                switch (direction)
                {
                    case "Right":
                        indexOfBullet = (indexOfBullet + strength) % cylinder.Count;
                        break;
                    case "Left":
                        if (indexOfBullet - strength < 0)
                        {
                            indexOfBullet = cylinder.Count - (Math.Abs(indexOfBullet - strength) % cylinder.Count);
                        }
                        else
                        {
                            indexOfBullet = indexOfBullet - strength;
                        }
                        break;
                }
                if (indexOfBullet == 2)
                {
                    
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }
                indexOfBullet = indexOfBullet + 1 == cylinder.Count ? 0 : indexOfBullet + 1;
            }
            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }

        }
    }
}
