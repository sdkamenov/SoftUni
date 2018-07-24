using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailbook = new Dictionary<string, string>();
            string name = string.Empty;
            string email = string.Empty;
            string commands = Console.ReadLine();;

            while (commands != "stop")
            {
                name = commands;
                email = Console.ReadLine();
                if (!mailbook.ContainsKey(name))
                {
                    mailbook.Add(name, email);
                }
                commands = Console.ReadLine();
            }

            foreach (var pair in mailbook.Where(x => !x.Value.EndsWith(".uk") && !x.Value.EndsWith(".us")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
