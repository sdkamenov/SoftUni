using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string sourceFile = "..//..//..//..//files//text.txt";
            string outputFile = "..//..//..//..//files//result.txt";
            string wordsFile = "..//..//..//..//files//words.txt";

            Dictionary<string, int> words = new Dictionary<string, int>();

            using (StreamReader streamReader = new StreamReader(wordsFile))
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();
                    if (!words.ContainsKey(line))
                    {
                        words.Add(line, 0);
                    }

                    line = streamReader.ReadLine();
                }

            }

            using (StreamReader streamReader = new StreamReader(sourceFile))
            {


                string line = streamReader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();
                    Regex regex = new Regex("[A-Za-z]+");

                    foreach (Match currentWord in regex.Matches(line))
                    {
                        if (words.ContainsKey(currentWord.Value))
                        {
                            words[currentWord.Value]++;
                        }
                    }

                    line = streamReader.ReadLine();
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(outputFile))
            {
                foreach (var word in words.OrderByDescending(v => v.Value))
                {
                    streamWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
