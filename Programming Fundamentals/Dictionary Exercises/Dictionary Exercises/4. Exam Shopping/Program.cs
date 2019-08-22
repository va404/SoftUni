using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> stockList = new Dictionary<string, long>();

            string input = Console.ReadLine();


            while (true)
            {
                if (input == "shopping time")
                {
                    break;
                }

                string[] tokens = input.Split(' ').ToArray();
                int quantity = 0;
                var parsingQuantity = int.TryParse(tokens[2], out quantity);
                var product = tokens[1];
                if (tokens[0] != "stock" && !parsingQuantity)
                {
                    continue;
                }
                if (!stockList.ContainsKey(product))
                {
                    stockList.Add(product, 0);
                }
                stockList[product] += quantity;

                input = Console.ReadLine();
            }

            string shoppingInput = Console.ReadLine();
            while (true)
            {
                if (shoppingInput == "exam time")
                {
                    foreach (var item in stockList)
                    {
                        if (item.Value > 0)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                    return;
                }

                string[] tokens = shoppingInput.Split(' ').ToArray();
                long quantityToBuy = 0;
                var parsingQuantity = long.TryParse(tokens[2], out quantityToBuy);
                var productToBuy = tokens[1];

                if (tokens[0] != "buy" && !parsingQuantity)
                {
                    continue;
                }
                if (!stockList.ContainsKey(productToBuy))
                {
                    Console.WriteLine($"{productToBuy} doesn't exist");
                }
                else
                {
                    if (stockList[productToBuy] <= 0)
                    {
                        Console.WriteLine($"{productToBuy} out of stock");
                    }
                    else
                    {
                        stockList[productToBuy] -= quantityToBuy;
                    }
                }
                
                shoppingInput = Console.ReadLine();
            }
        }
    }
}
