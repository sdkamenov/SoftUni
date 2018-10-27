using System;
using System.Linq;

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = x => x.Min();

            Console.WriteLine(minFunc(ints));
        }
    }
}
