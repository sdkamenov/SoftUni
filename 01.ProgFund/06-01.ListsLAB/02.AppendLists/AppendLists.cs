using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split('|').Reverse().Select(s => string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))));

            List<string> input = Console.ReadLine().Split('|').Reverse().ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string text = input[i];
                string[] splitted = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string merged = string.Join(" ", splitted);

                result.Add(merged);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
