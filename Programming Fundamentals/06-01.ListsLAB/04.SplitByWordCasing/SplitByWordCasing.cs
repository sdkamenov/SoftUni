using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(",;:.!()\"'\\/[ ]".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> mixed = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();


            for (int i = 0; i < arr.Length; i++)
            {
                string current = arr[i];

                if(IsLower(current))
                {
                    lowerCase.Add(current);
                }
                else if (IsUpper(current))
                {
                    upperCase.Add(current);
                }
                else
                {
                    mixed.Add(current);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }

        static bool IsUpper(string word)
        {
            foreach (char symbol  in word)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLower(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
