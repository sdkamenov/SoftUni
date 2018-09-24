using System;
using System.Collections.Generic;
using System.Linq;

namespace RubikMatrix
{
    class RubikMatrix
    {
        static void Main(string[] args)
        {
            byte[] sizes = Console.ReadLine().Split().Select(byte.Parse).ToArray();
            byte commandCount = byte.Parse(Console.ReadLine());

            int[,] rubikMatrix = new int[sizes[0], sizes[1]];

            int count = 1;
            for (int row = 0; row < rubikMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rubikMatrix.GetLength(1); col++)
                {
                    rubikMatrix[row, col] = count++;
                }
            }


            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                int rowColIndex = int.Parse(input[0]);
                string direction = input[1];
                uint moves = uint.Parse(input[2]);

                switch (direction)
                {
                    case "down":
                        MoveDown(rubikMatrix, rowColIndex, moves % sizes[0]);
                        break;
                    case "up":
                        MoveUp(rubikMatrix, rowColIndex, moves % sizes[0]);
                        break;
                    case "left":
                        MoveLeft(rubikMatrix, rowColIndex, moves % sizes[0]);
                        break;
                    case "right":
                        MoveRight(rubikMatrix, rowColIndex, moves % sizes[0]);
                        break;
                }
            }

            int counter = 1;
            for (int row = 0; row < rubikMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < rubikMatrix.GetLength(1); col++)
                {
                    if (rubikMatrix[row, col] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearrange(rubikMatrix, row, col, counter);
                        counter++;
                    }
                }
            }

            //var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //var commandsLength = int.Parse(Console.ReadLine());
            //var matrix = new int[tokens[0]][];

            //for (int row = 0, counter = 1; row < matrix.Length; row++)
            //{
            //    matrix[row] = new int[tokens[1]];

            //    for (int col = 0; col < matrix[row].Length; col++, ++counter)
            //    {
            //        matrix[row][col] = counter;
            //    }
            //}

            //for (int commandIndex = 0; commandIndex < commandsLength; commandIndex++)
            //{
            //    var inputTokens = Console.ReadLine().Split(' ');
            //    var selectedIndex = int.Parse(inputTokens[0]);
            //    var command = inputTokens[1];
            //    var rollTimes = int.Parse(inputTokens[2]);

            //    switch (command)
            //    {
            //        case "up":
            //            {
            //                var queue = new Queue<int>();

            //                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            //                {
            //                    queue.Enqueue(matrix[rowIndex][selectedIndex]);
            //                }

            //                for (int i = 0; i < rollTimes % matrix.Length; i++)
            //                {
            //                    var number = queue.Dequeue();
            //                    queue.Enqueue(number);
            //                }

            //                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            //                {
            //                    matrix[rowIndex][selectedIndex] = queue.Dequeue();
            //                }

            //                break;
            //            }
            //        case "down":
            //            {
            //                var queue = new Queue<int>();

            //                for (int rowIndex = matrix.Length - 1; rowIndex >= 0; rowIndex--)
            //                {
            //                    queue.Enqueue(matrix[rowIndex][selectedIndex]);
            //                }

            //                for (int i = 0; i < rollTimes % matrix.Length; i++)
            //                {
            //                    var number = queue.Dequeue();
            //                    queue.Enqueue(number);
            //                }

            //                for (int rowIndex = matrix.Length - 1; rowIndex >= 0; rowIndex--)
            //                {
            //                    matrix[rowIndex][selectedIndex] = queue.Dequeue();
            //                }

            //                break;
            //            }
            //        case "left":
            //            {
            //                for (int i = 0; i < rollTimes % matrix[selectedIndex].Length; i++)
            //                {
            //                    var first = matrix[selectedIndex][0];
            //                    Array.Copy(matrix[selectedIndex], 1, matrix[selectedIndex], 0,
            //                        matrix[selectedIndex].Length - 1);
            //                    matrix[selectedIndex][matrix[selectedIndex].Length - 1] = first;
            //                }

            //                break;
            //            }
            //        case "right":
            //            {
            //                for (int i = 0; i < rollTimes % matrix[selectedIndex].Length; i++)
            //                {
            //                    var last = matrix[selectedIndex][matrix[selectedIndex].Length - 1];
            //                    Array.Copy(matrix[selectedIndex], 0, matrix[selectedIndex], 1,
            //                        matrix[selectedIndex].Length - 1);
            //                    matrix[selectedIndex][0] = last;
            //                }

            //                break;
            //            }
            //    }
            //}

            //for (int row = 0, previous = 0; row < matrix.Length; row++)
            //{
            //    for (int col = 0; col < matrix[0].Length; col++, ++previous)
            //    {
            //        if (matrix[row][col] - 1 == previous)
            //        {
            //            Console.WriteLine("No swap required");
            //        }
            //        else
            //        {
            //            for (int nestedRow = row; nestedRow < matrix.Length; nestedRow++)
            //            {
            //                var foundColumn = Array.IndexOf(matrix[nestedRow], previous + 1);

            //                if (foundColumn >= 0)
            //                {
            //                    matrix[nestedRow][foundColumn] = matrix[row][col];
            //                    matrix[row][col] = previous + 1;
            //                    Console.WriteLine($"Swap ({row}, {col}) with ({nestedRow}, {foundColumn})");
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
        }


        private static void Rearrange(int[,] rubikMatrix, int row, int col, int counter)
        {
            for (int targetRow = 0; targetRow < rubikMatrix.GetLength(0); targetRow++)
            {
                for (int targetCol = 0; targetCol < rubikMatrix.GetLength(1); targetCol++)
                {
                    if (rubikMatrix[targetRow, targetCol] == counter)
                    {
                        rubikMatrix[targetRow, targetCol] = rubikMatrix[row, col];
                        rubikMatrix[row, col] = counter;
                        Console.WriteLine($"Swap ({row}, {col}) with ({targetRow}, {targetCol})");
                        return;
                    }
                }
            }
        }


        private static void MoveRight(int[,] rubikMatrix, int row, uint moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElement = rubikMatrix[row, rubikMatrix.GetLength(1) - 1];
                for (int col = rubikMatrix.GetLength(0) - 1; col > 0; col--)
                {
                    rubikMatrix[row, col] = rubikMatrix[row, col - 1];
                }
                rubikMatrix[row, 0] = lastElement;
            }
        }

        private static void MoveLeft(int[,] rubikMatrix, int row, uint moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElement = rubikMatrix[row, 0];
                for (int col = 0; col < rubikMatrix.GetLength(0) - 1; col++)
                {
                    rubikMatrix[row, col] = rubikMatrix[row, col + 1];
                }
                rubikMatrix[row, rubikMatrix.GetLength(0) - 1] = firstElement;
            }
        }

        private static void MoveUp(int[,] rubikMatrix, int col, uint moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int firstElemnt = rubikMatrix[0, col];
                for (int row = 0; row < rubikMatrix.GetLength(0) - 1; row++)
                {
                    rubikMatrix[row, col] = rubikMatrix[row + 1, col];
                }
                rubikMatrix[rubikMatrix.GetLength(0) - 1, col] = firstElemnt;
            }
        }

        private static void MoveDown(int[,] rubikMatrix, int col, uint moves)
        {
            for (int i = 0; i < moves; i++)
            {
                int lastElemnt = rubikMatrix[rubikMatrix.GetLength(0) - 1, col];
                for (int row = rubikMatrix.GetLength(0) - 1; row > 0; row--)
                {
                    rubikMatrix[row, col] = rubikMatrix[row - 1, col];
                }
                rubikMatrix[0, col] = lastElemnt;
            }
        }
    }
}
