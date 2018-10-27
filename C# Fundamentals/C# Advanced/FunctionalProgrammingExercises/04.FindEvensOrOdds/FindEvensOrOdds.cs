using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<string> even = x => x == "even";

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string condition = Console.ReadLine();

            List<int> result = new List<int>();

            Enumerable.Range(range[0], range[1] - range[0] + 1)
                .Where(x => even(condition) ? isEven(x) : !isEven(x))
                .ToList()
                .ForEach(result.Add);

            Console.WriteLine(string.Join(" ",  result));
        }
    }
}
