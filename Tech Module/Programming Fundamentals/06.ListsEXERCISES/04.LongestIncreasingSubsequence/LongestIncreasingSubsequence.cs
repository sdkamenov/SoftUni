using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var longestSeq = FindLongestIncSeq(arr);
            Console.WriteLine(string.Join(" ", longestSeq));
        }

        static int[] FindLongestIncSeq(int[] arr)
        {
            var lengths = new int[arr.Length];
            var previous = new int[arr.Length];

            var bestLength = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < arr.Length; anchor++)
            {
                lengths[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = arr[anchor];
                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = arr[i];
                    if (currentNum < anchorNum && lengths[i] + 1 > lengths[anchor])
                    {
                        lengths[anchor] = lengths[i] + 1;
                        previous[anchor] = i;
                    }
                }

                if (lengths[anchor] > bestLength)
                {
                    bestLength = lengths[anchor];
                    lastIndex = anchor;
                }
            }
            var longestIncSubSeq = new List<int>();

            while (lastIndex != -1)
            {
                longestIncSubSeq.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestIncSubSeq.Reverse();


            return longestIncSubSeq.ToArray();
        }
    }
}
