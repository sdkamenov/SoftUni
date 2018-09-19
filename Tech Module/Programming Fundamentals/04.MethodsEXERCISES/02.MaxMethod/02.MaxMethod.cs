using System;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            max = GetMax(max, thirdNumber);

            Console.WriteLine(max);

        }

        static int GetMax(int first, int second)
        {
            int maxNum = 0;

            if (first > second)
            {
                maxNum = first;
            }
            else
            {
                maxNum = second;
            }

            return maxNum;
        }
    }
}
