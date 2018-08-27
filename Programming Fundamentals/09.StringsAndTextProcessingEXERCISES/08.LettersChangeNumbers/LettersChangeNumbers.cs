using System;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            foreach (var word in words)
            {
                char firstSymbol = word[0];
                char lastSymbol = word[word.Length - 1];

                string numberAsString = word.Substring(1, word.Length - 2);
                int number = int.Parse(numberAsString);

                double sum = 0;

                if (char.IsUpper(firstSymbol))
                {
                    sum += number / (firstSymbol - 64.0);
                }
                else
                {
                    sum += number * (firstSymbol - 96.0);
                }

                if (char.IsUpper(lastSymbol))
                {
                    sum -= (lastSymbol - 64.0);
                }
                else
                {
                    sum += (lastSymbol - 96.0);
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
