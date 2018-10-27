using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            Action<int[]> print = p => Console.WriteLine(string.Join(" ", p));
            Func<int, int, int> sortFunc = (a, b) =>
                                     (a % 2 == 0 && b % 2 != 0) ? -1 :
                                     (a % 2 != 0 && b % 2 == 0) ? 1 :
                                     a.CompareTo(b);

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(inputNumbers, new Comparison<int>(sortFunc));
            print(inputNumbers);
        }
    }
}
