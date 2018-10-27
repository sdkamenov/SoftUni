using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, bool> isDivisible = (i, d) => i % d == 0;
            List<int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool divisible = true;

                foreach (var div in divisors)
                {
                    if (!isDivisible(i, div))
                    {
                        divisible = false;
                        break;
                    }
                }

                if (divisible)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
