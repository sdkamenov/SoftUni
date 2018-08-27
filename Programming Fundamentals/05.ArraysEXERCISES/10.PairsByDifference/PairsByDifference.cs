using System;
using System.Linq;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j + 1]) == diff)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
