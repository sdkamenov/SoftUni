using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> counts = new List<int>();
            numbers.Sort();

            int count = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 1;
                }
            }
            Console.WriteLine($"{numbers[numbers.Count - 1]} -> {count}");

        }
    }
}
