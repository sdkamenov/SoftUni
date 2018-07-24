using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var logs = new Dictionary<string, Dictionary<string, int>>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string ip = tokens[0];
                string userName = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (logs.ContainsKey(userName) == false)
                {
                    logs.Add(userName, new Dictionary<string, int>());
                }
                if (logs[userName].ContainsKey(ip) ==false)
                {
                    logs[userName].Add(ip, duration);
                }
                else
                {
                    logs[userName][ip] += duration;
                }

            }

            foreach (var log in logs.OrderBy(x=> x.Key))
            {
                string username = log.Key;
                int totalDuration = log.Value.Sum(x => x.Value);

                string[] ips = log.Value.Keys.OrderBy(x => x).ToArray();

                Console.WriteLine($"{username}: {totalDuration} [{string.Join(", ", ips)}]");
            }
        }
    }
}
