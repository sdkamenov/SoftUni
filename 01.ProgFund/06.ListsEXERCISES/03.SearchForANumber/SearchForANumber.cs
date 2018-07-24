using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //if (numbers.Take(commands[0]).Skip(commands[1]).Contains(commands[2]))
            //{
            //    Console.WriteLine("YES!");
            //}
            //else
            //{
            //    Console.WriteLine("NO!");
            //}

            List<int> result = new List<int>();
            int elementsToTake = commands[0];
            int elementsToDelete = commands[1];

            for (int i = 0; i < elementsToTake; i++)
            {
                result.Add(numbers[i]);
            }
            for (int i = 0; i < elementsToDelete; i++)
            {
                result.RemoveAt(0);
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == commands[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
