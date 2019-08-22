using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<string> notes = new List<string>(new string[]{
                "C",
                "C#",
                "D",
                "D#",
                "E",
                "F",
                "F#",
                "G",
                "G#",
                "A",
                "A#",
                "B"
            });

            List<double> frequencies = new List<double>(new double[]{
                261.63,
                277.18,
                293.66,
                311.13,
                329.63,
                349.23,
                369.99,
                392.00,
                415.30,
                440.00,
                466.16,
                493.88
            });

            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<string> allNotes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            double naturalsSum = 0;
            double sharpsSum = 0;


            foreach (double frequency in input)
            {
                int index = frequencies.IndexOf(frequency);
                if (IsSharp(notes[index]))
                {
                    sharps.Add(notes[index]);
                    sharpsSum += frequencies[index];
                }
                else
                {
                    naturals.Add(notes[index]);
                    naturalsSum += frequencies[index];
                }

                allNotes.Add(notes[index]);
            }


            Console.WriteLine($"Notes: {string.Join(" ", allNotes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {naturalsSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");
        }
        static bool IsSharp(string input)
        {
            foreach (char c in input)
            {
                if (c == '#')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
