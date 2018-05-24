using System;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int product = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    product = i * j * 3;
                    totalSum += product;
                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                    }
                    if (i == 1 && j == m)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum}");
                    }

                }
            }

        }
    }
}
