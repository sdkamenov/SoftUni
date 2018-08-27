using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            int counter = 0;
            while (factorial % 10 == 0)
            {
                factorial /= 10;
                counter++;
            }
            Console.WriteLine(counter);

        }
    }
}
