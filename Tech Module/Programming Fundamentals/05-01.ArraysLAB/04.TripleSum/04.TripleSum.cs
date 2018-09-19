using System;
using System.Linq;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a+1; b < arr.Length; b++)
                {
                    int sum = arr[a] + arr[b];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[a]} + {arr[b]} == {sum}");
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
