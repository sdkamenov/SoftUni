using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i], 1);
                }
                else
                {
                    chars[input[i]]++;
                }
            }

            foreach (var ch in chars.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
