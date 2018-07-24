using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Odd")
                {
                    foreach (var num in numbers)
                    {
                        if (num % 2 != 0)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (input == "Even")
                {
                    foreach (var num in numbers)
                    {
                        if (num % 2 == 0)
                        {
                            Console.Write($"{num} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }

                string[] tokens = input.Split(' ');

                string command = tokens[0];

                switch (command)
                {
                    case "Delete":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAll(x => x == numberToRemove);
                        break;
                    case "Insert":
                        int elementToInsert = int.Parse(tokens[1]);
                        int elementPosition = int.Parse(tokens[2]);
                        numbers.Insert(elementPosition, elementToInsert);
                        break;
                }
            }
        }
    }
}
