using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var logs = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                string[] ipInput = input[0].Split("=").ToArray();
                string ip = ipInput[1];
                string[] userInput = input[2].Split("=").ToArray();
                string user = userInput[1];

                if (logs.ContainsKey(user) == false)
                {
                    var current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    logs.Add(user, current);
                }
                else
                {
                    if (logs[user].ContainsKey(ip) == false)
                    {
                        logs[user].Add(ip, 1);
                    }
                    else
                    {
                        logs[user][ip]++;
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var user in logs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: ");
                List<string> temp = new List<string>();
                foreach (var ipPair in user.Value)
                {
                    temp.Add($"{ipPair.Key} => {ipPair.Value}");
                }
                Console.WriteLine(string.Join(", ", temp) + ".");
            }
        }
    }
}
