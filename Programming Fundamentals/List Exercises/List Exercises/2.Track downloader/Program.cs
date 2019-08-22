using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blacklistWords = Console.ReadLine().Split(' ').ToList();
            List<string> listToOutput = new List<string>();
            string inputFileNames = Console.ReadLine();
            
            while (inputFileNames != "end")
            {
                bool isContaining = false;
                for (int i = 0; i < blacklistWords.Count; i++)
                {
                    if (inputFileNames.Contains(blacklistWords[i]))
                    {
                        isContaining = true;
                    }
                    
                }
                if (!isContaining)
                {
                    listToOutput.Add(inputFileNames);
                }

                inputFileNames = Console.ReadLine();
            }
            listToOutput.Sort();

            Console.WriteLine(string.Join("\n", listToOutput));
           
        }
    }
}
