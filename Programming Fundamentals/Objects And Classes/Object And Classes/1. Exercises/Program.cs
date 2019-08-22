using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string Course { get; set; }
        public string JudgeLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercise(string topic, string course, string judgeLink, List<string> problems)
        {
            this.Topic = topic;
            this.Course = course;
            this.JudgeLink = judgeLink;
            this.Problems = problems;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();
            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string topic = tokens[0];
                string course = tokens[1];
                string judgeLink = tokens[2];
                List<string> problems = tokens[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                exercises.Add(new Exercise(topic, course, judgeLink, problems));

                input = Console.ReadLine();
            }
            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.Course}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeLink}");

                int counter = 1;
                foreach (var prob in exercise.Problems)
                {
                    Console.WriteLine($"{counter}. {prob}");
                    counter++;
                }
            }
        }

    }
}
