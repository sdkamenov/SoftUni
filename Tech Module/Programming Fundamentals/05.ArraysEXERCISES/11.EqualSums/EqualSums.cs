using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int totalSum = 0;
            foreach (int number in numbers)
            {
                totalSum += number;
            }

            int leftSum = 0;
            int rightSum = totalSum;
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                rightSum -= currentNumber;

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }

                leftSum += currentNumber;
            }

            if (isFound == false)
            {
                Console.WriteLine("no");
            }



            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //if (arr.Length == 1)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}

            //bool isValid = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int leftSum = 0;
            //    int rightSum = 0;

            //    for (int j = 0; j < i; j++)
            //    {
            //        leftSum += arr[j];
            //    }

            //    for (int k = i + 1; k < arr.Length; k++)
            //    {
            //        rightSum += arr[k];
            //    }

            //    if (leftSum == rightSum)
            //    {
            //        isValid = true;
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            //if (isValid == false)
            //{
            //    Console.WriteLine("no");
            //}
        }
    }
}
