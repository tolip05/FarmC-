using System;
using System.Collections.Generic;
using System.Linq;
namespace wardrobe
{
    class wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string,
                Dictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                var clothes = input[1].Split(',',StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color,new Dictionary<string, int>());
                }
                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item,0);
                    }
                    wardrobe[color][item]++;
                }
            }

            var dressCode = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);

            string colors = dressCode[0];
            string dress = dressCode[1];

         //   var sorted = wardrobe.OrderBy(z => z.Value)
         //       .ToDictionary(x => x.Key, x => x.Value);

            foreach (var i in wardrobe)
            {
                Console.WriteLine($"{i.Key} clothes:");
                var a = i.Value;
                foreach (var m in a)
                {
                    if (i.Key== colors && m.Key == dress)
                    {
                        Console.WriteLine($"* {m.Key} - {m.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {m.Key} - {m.Value}");
                    }
                }
            }
        }
    }
}
