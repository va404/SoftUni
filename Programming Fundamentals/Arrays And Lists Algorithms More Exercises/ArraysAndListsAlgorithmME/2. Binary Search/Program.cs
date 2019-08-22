using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int searchedNumber = int.Parse(Console.ReadLine());
            int iterationsCounter = 0;
            bool isFound = false;
            for (int i = 0; i < input.Count; i++)
            {
                iterationsCounter++;
                if (input[i] == searchedNumber)
                {

                    isFound = true;
                    break;
                }

            }
            if (isFound)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Linear search made {iterationsCounter} iterations");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {iterationsCounter} iterations");
            }


            bool swapped = false;
            int temp = 0;
            do
            {
                swapped = false;
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
            iterationsCounter = 0;
            int lowerBound = 0;
            int upperBound = input.Count-1;
            bool searchedNumFound = false;



            while (searchedNumFound == false)
            {
                if (upperBound < lowerBound)
                {
                   
                    break;
                }
                int midPoint = lowerBound + (upperBound - lowerBound) / 2;
                if (input[midPoint] < searchedNumber)
                {
                    lowerBound = midPoint + 1;
                    
                }
                if (input[midPoint] > searchedNumber)
                {
                    upperBound = midPoint - 1;
                  
                }

                if (input[midPoint] == searchedNumber)
                {
                    
                    searchedNumFound = true;
                }
                iterationsCounter++;
            }
            if (searchedNumFound)
            {
                Console.WriteLine($"Binary search made {iterationsCounter} iterations");
            }
            else
            {
                Console.WriteLine($"Binary search made {iterationsCounter} iterations");
            }
        }
    }
}
