using System;
using System.Linq;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            Action<int[]> print = p => Console.WriteLine(string.Join(" ", p));
            Func<int[], int[]> addOneFunc = nums => nums.Select(x => x + 1).ToArray();
            Func<int[], int[]> subtractOneFunc = nums => nums.Select(x => x - 1).ToArray();
            Func<int[], int[]> multiplyBy2 = nums => nums.Select(x => x * 2).ToArray();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if (input == "add")
                {
                    numbers = addOneFunc(numbers);
                }
                else if (input == "subtract")
                {
                    numbers = subtractOneFunc(numbers);
                }
                else if (input == "multiply")
                {
                    numbers = multiplyBy2(numbers);
                }
                else if (input == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
