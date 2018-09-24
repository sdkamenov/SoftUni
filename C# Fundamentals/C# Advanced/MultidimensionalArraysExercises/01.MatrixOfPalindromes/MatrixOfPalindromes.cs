using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] palindomes = new char[sizes[0], sizes[1]];

            char a = 'a';
            char b = 'a';

            for (int row = 0; row < palindomes.GetLength(0); row++)
            {
                for (int col = 0; col < palindomes.GetLength(1); col++)
                {
                    Console.Write(a);
                    Console.Write(b);
                    Console.Write(a);
                    Console.Write(" ");
                    b++;
                }
                Console.WriteLine();
                a++;
                b = a;
            }
        }
    }
}
