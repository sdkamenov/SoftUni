using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertedFromBaseNToBase10
{
    class ConvertedFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int @base = int.Parse(input[0]);
            string numAsString = input[1];

            BigInteger sum = 0;
            int power = 0;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                char currentChar = numAsString[i];
                int currentNumber = int.Parse(currentChar.ToString());

                BigInteger currentSum = currentNumber * BigInteger.Pow(@base, power);
                sum += currentSum;
                power++;
            }

            Console.WriteLine(sum);

        }
    }
}
