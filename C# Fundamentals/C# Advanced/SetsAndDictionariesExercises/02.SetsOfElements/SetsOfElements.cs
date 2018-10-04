using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = lengths[0];
            int m = lengths[1];
            int input;
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();



            for (int i = 0; i < n; i++)
            {
                firstSet.Add(input = int.Parse(Console.ReadLine()));
            }
            for (int j = 0; j < m; j++)
            {
                secondSet.Add(input = int.Parse(Console.ReadLine()));
            }

            List<int> result = new List<int>();

            foreach (var number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
