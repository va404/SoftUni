using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            int index = 0;
            bool isBlown = false;

            while (energy > 0)
            {
                isBlown = false;
                string[] currentCommand = command[index].Split('|');
                string action = currentCommand[0];

                if (action == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                int value = int.Parse(currentCommand[1]);

                switch (action)
                {

                    case "Left":
                        index = Math.Abs(index - value) % command.Count;
                        energy -= value;
                        break;

                    case "Right":
                        index = (index + value) % command.Count;
                        energy -= value;
                        break;

                    case "Bomb":
                        command.RemoveAt(index);
                        index = 0;
                        energy -= value;
                        isBlown = true;
                        break;
                }

                if (command[command.Count - 1] != "RabbitHole")
                {
                    command.RemoveAt(command.Count - 1);
                }
                command.Add("Bomb|" + energy);


                if (energy <= 0 && isBlown)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energy <= 0 && !isBlown)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            }
        }
    }
}
