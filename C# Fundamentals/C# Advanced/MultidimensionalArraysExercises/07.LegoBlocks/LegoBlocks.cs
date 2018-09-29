using System;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int totalCells = 0;

            int[][] firstMatrix = new int[size][];
            int[][] secondMatrix = new int[size][];

            int[][] finalMatrix = new int[size][];

            for (int row = 0; row < firstMatrix.Length; row++)
            {
                firstMatrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                totalCells += firstMatrix[row].Length;

            }

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                secondMatrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToArray();
                totalCells += secondMatrix[row].Length;
            }

            int colLength = firstMatrix[0].Length + secondMatrix[0].Length;

            bool isFit = true;

            for (int row = 0; row < firstMatrix.Length; row++)
            {
                if (firstMatrix[row].Length + secondMatrix[row].Length != colLength)
                {
                    isFit = false;
                    break;
                }
            }

            if (isFit)
            {
                for (int row = 0; row < secondMatrix.Length; row++)
                {
                    Console.WriteLine($"[{string.Join(", ", firstMatrix[row])}, {string.Join(", ", secondMatrix[row])}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
        }
    }
}
