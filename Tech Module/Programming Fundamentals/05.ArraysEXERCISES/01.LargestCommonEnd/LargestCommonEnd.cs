using System;
using System.Linq;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int minLenght = Math.Min(firstArray.Length, secondArray.Length);
            int difference = Math.Abs(firstArray.Length - secondArray.Length);

            int leftLength = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    break;
                }
                leftLength++;
            }

            firstArray = firstArray.Reverse().ToArray();
            secondArray = secondArray.Reverse().ToArray();

            int rightLenght = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    break;
                }
                rightLenght++;
            }


            Console.WriteLine(Math.Max(leftLength, rightLenght));

        }
    }
}
