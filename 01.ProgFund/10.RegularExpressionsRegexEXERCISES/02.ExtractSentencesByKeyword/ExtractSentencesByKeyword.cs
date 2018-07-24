using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();

            string pattern = $@"\b{searchWord}\b";

            Regex regex = new Regex(pattern);

            string[] input = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            foreach (var word in input)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
