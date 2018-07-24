using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listOfSquareNums = new List<int>();

            for (int i = 0; i < listOfNums.Count; i++)
            {
                int current = listOfNums[i];
                double square = Math.Sqrt(current);
                int whole = (int)square;

                if (square == whole)
                {
                    listOfSquareNums.Add(current);
                }
            }
            listOfSquareNums.Sort();
            listOfSquareNums.Reverse();
            Console.WriteLine(string.Join(" ", listOfSquareNums));
        }
    }
}
