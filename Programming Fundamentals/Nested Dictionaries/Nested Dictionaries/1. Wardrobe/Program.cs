using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string,int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                 
                string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.None).ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int> ());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    Dictionary<string, int> dictClothes = wardrobe[color];
                    if (!dictClothes.ContainsKey(clothes[j]))
                    {
                        dictClothes.Add(clothes[j], 0);
                    }
                    dictClothes[clothes[j]] ++;
                }

            }
            List<string> searchedWear = Console.ReadLine().Split(' ').ToList();
            string searchedColor = searchedWear[0];
            
            string searchedItem = searchedWear[1];
       


            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                Dictionary<string, int> dictValue = item.Value;
                foreach (var values in dictValue)
                {
                    if (item.Key == searchedColor && values.Key == searchedItem)
                    {
                        Console.WriteLine($"* {values.Key} - {values.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {values.Key} - {values.Value}");
                    }

                }

            }

        }
    }
}