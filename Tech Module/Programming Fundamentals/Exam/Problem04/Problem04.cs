using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace Problem04
{
    class Problem04
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<string, int>> users = new Dictionary<string, KeyValuePair<string, int>>();
            Dictionary<string, int> count = new Dictionary<string, int>();
            int skipped = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }


                string[] tokens = input.Split("-");
                if (tokens.Length == 3)
                {
                    string username = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (users.ContainsKey(username) == false)
                    {
                        users.Add(username, new KeyValuePair<string, int>(language, points));
                    }
                    else
                    {
                        users[username] = new KeyValuePair<string, int>(language, points);
                    }

                    if (points > users[username].Value)
                    {
                        users[username] = new KeyValuePair<string, int>(language, points);
                        skipped++;
                    }

                    if (count.ContainsKey(language) == false)
                    {
                        count.Add(language, 1);
                    }
                    else
                    {
                        count[language]++;
                    }

                }
                else if (tokens.Length == 2)
                {
                    string name = tokens[0];
                    string command = tokens[1];

                    if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                    }
                }
            }

            Console.WriteLine("Results:");

            foreach (var item in users.OrderByDescending(x => x.Value.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value.Value}");
            }


            Console.WriteLine("Submissions:");
            foreach (var item in count.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
