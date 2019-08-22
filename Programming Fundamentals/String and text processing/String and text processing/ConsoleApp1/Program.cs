using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Find_the_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = Console.ReadLine().Split();

            
            string letterToSearch = inputArr[0];
            int numberOfLetter = int.Parse(inputArr[1]);

            int index = -1;
            do
            {
                numberOfLetter--;
                index = input.IndexOf(letterToSearch, index + 1);
            } while (index!=-1 && numberOfLetter>0);

            if (index!=-1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
