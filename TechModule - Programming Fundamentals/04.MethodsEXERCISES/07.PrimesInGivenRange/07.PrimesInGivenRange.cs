using System;
using System.Collections.Generic;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimes(startNumber, endNumber);
            Console.WriteLine(string.Join(", ", primes));
        }

         static List<int> GetPrimes(int startNumber, int endNumber)
        {
            List<int> list = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        static bool IsPrime(int number)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
