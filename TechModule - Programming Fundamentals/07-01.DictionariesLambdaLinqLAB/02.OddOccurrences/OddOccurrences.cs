using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(s=>s.ToLower()).ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                words[word]++;
                }
            }

            List<string> oddCount = new List<string>();
            foreach (var kvp in words)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddCount.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",  oddCount));
        }
    }
}
