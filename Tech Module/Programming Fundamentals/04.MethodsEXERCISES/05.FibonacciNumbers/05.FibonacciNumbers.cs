using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(FibonacciNumbers(n));
            }

        }

        static int FibonacciNumbers(int n)
        {

            int firstNum = 0;
            int secondNum = 1;
            int nextNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                nextNumber = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNumber;
            }
            return nextNumber;
        }
    }
}
