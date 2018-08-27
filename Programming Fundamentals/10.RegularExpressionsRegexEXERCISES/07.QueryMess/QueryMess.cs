using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string pattern = @"([^\=&\?]+)=([^\=&\?]+)";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                MatchCollection matches = regex.Matches(input);

                var keys = new Dictionary<string, List<string>>();
                foreach (Match match in matches)
                {
                    string key = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();

                    if (keys.ContainsKey(key) == false)
                    {
                        keys.Add(key, new List<string>());
                    }
                    keys[key].Add(value);
                }

                foreach (var key in keys)
                {
                    Console.Write($"{key.Key}=[{string.Join(", ", key.Value)}]");
                }
                Console.WriteLine();
            }
        }
    }
}
