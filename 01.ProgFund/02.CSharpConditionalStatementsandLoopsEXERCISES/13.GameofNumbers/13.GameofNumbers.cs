using System;

namespace _13.GameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int digitOne = 0;
            int digitTwo = 0;
            bool magicNumberFound = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        digitOne = i;
                        digitTwo = j;
                        magicNumberFound = true;
                    }
                }
            }
            if (magicNumberFound)
            {
                Console.WriteLine($"Number found! {digitOne} + {digitTwo} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
