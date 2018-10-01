using System;
using System.Collections.Generic;
using System.Linq;
namespace thevloger
{
    class vloger
    {
        static void Main(string[] args)
        {

            var vlogers =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            var input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] elements = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string user = elements[0];
                string command = elements[1];

                string targetUser = elements[2];

                if (command == "joined")
                {
                    if (!vlogers.ContainsKey(user))
                    {
                        vlogers.Add(user, new Dictionary<string, SortedSet<string>>());
                        vlogers[user].Add("followers", new SortedSet<string>());
                        vlogers[user].Add("following", new SortedSet<string>());
                    }
                    
                }
                else if (command == "followed")
                {
                    bool isSamePerson = user == targetUser;
                    if (vlogers.ContainsKey(user) && vlogers.ContainsKey(targetUser)
                        && !isSamePerson)
                    {
                        vlogers[user]["following"].Add(targetUser);
                        vlogers[targetUser]["followers"].Add(user);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");

            var sortedVlogers = vlogers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count);
            int counter = 1;

            foreach (var item in sortedVlogers)
            {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var i in item.Value["followers"])
                    {
                        Console.WriteLine($"* {i}");
                    }
                }
                counter++;
            }
        }
    }
}
