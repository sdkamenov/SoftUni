using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rowCount = Int32.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowCount][];

            for (int row = 0; row < rowCount; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(Int32.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow;
            }

            //string[] input = Console.ReadLine().Split();
            //while (input[0]?.ToLower() != "end")
            //{

            //}

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end")
                {
                    break;
                }

                int row = Int32.Parse(input[1]);
                int col = Int32.Parse(input[2]);
                int value = Int32.Parse(input[3]);

                if (row < 0 ||
                    row > jaggedArray.Length - 1 ||
                    col < 0 ||
                    col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates!");
                    continue;
                }

                switch (input[0]?.ToLower())
                {
                    case "add":
                        jaggedArray[row][col] += value;
                        break;
                    case "subtract":
                        jaggedArray[row][col] -= value;
                        break;
                }
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
