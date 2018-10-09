using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class TheVLogger
    {
        static void Main(string[] args)
        {

            var vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Statistics")
                {
                    break;
                }

                string user = input[0];
                string command = input[1];
                string targetUser = input[2];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(user))
                    {
                        vloggers.Add(user, new Dictionary<string, SortedSet<string>>());
                        vloggers[user].Add("following", new SortedSet<string>());
                        vloggers[user].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    bool isSamePerson = user == targetUser;

                    if (vloggers.ContainsKey(user) && vloggers.ContainsKey(targetUser) && !isSamePerson)
                    {
                        vloggers[user]["following"].Add(targetUser);
                        vloggers[targetUser]["followers"].Add(user);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var sortedVlogs = vloggers.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x=> x.Value["following"].Count);

            int counter = 1;

            foreach (var item in sortedVlogs)
            {
                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var followerName in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {followerName}");
                    }
                }
                counter++;
            }
        }
    }
}
