using System;
using System.Linq;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] inputNames = Console.ReadLine().Split();

            Func<string, int, bool> isEqualSum = (name, totalSum) => name.Sum(x => x) >= totalSum;
            Func<string[], Func<string, int, bool>, string> getName = (names, isEqualSumOfAscii) => names.FirstOrDefault(x => isEqualSum(x, number));

            var result = getName(inputNames, isEqualSum);
            Console.WriteLine(result);
        }
    }
}
