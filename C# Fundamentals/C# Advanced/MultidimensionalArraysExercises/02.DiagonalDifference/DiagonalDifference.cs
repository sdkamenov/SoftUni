using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] squareMatrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] rowElems = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    squareMatrix[row, col] = rowElems[col];
                }
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                primaryDiagonalSum += squareMatrix[i, i];
            }

            for (int j = 0; j < size; j++)
            {
                secondaryDiagonalSum += squareMatrix[j, size - 1 - j];
            }

            int result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(result);
        }
    }
}
