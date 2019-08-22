using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] names = Console.ReadLine().Split(' ');
            string commands = Console.ReadLine();

            while (commands != "done")
            {
                string[] commandList = commands.Split(' '); ;
                switch (commandList[0])
                {
                    case "call":
                        for (long i = 0; i < names.Length; i++)
                        {
                            if (commandList[1] == names[i])
                            {
                                Console.WriteLine($"calling {numbers[i]}...");
                                
                                if (IsEven(numbers[i]))
                                {
                                    long duration = numbers[i];
                                    var seconds = SumOfDigits(numbers[i]) % 60;
                                    var minutes = SumOfDigits(numbers[i]) / 60;
                                    Console.WriteLine($"call ended. duration {minutes:00} : {seconds:00}"); 
                                }
                                else
                                {
                                    Console.WriteLine("no answer.");
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine($"calling {names[i]}...");
                                break;
                            }
                        }
                        break;
                }
                commands = Console.ReadLine();
            }
        }

        static long SumOfDigits(long num)
        {
            long sum = 0L;
            do
            {
                sum += num % 10;
                num /= 10;

            } while (num != 0);
            return sum;
        }
        static bool IsEven(long num)
        {
            if (SumOfDigits(num) % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static void CallDuration(int num)
        {
            var seconds = SumOfDigits(num) % 60;
            var minutes = SumOfDigits(num) / 60;
            Console.WriteLine($"{minutes:00} : {seconds:00}");
        }
        
    }
}
