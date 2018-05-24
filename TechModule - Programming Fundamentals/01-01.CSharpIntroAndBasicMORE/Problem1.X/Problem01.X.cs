using System;

namespace Problem1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int preX = 0;
            int midSpace = n - 2;

            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', preX), new string(' ', midSpace));
                midSpace -= 2;
                preX++;
            }
            Console.WriteLine("{0}x", new string(' ', n /2));

            midSpace = 1;
            for (int i = n/2 -1; i >= 0; i--)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', i), new string(' ', midSpace));
                midSpace += 2;
                preX--;
            }
        }
    }
}
