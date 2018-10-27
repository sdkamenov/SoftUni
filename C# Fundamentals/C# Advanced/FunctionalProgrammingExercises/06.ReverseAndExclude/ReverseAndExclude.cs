using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divNumber = int.Parse(Console.ReadLine());

            Action<List<int>> print = p => Console.WriteLine(string.Join(" ", p));
            Action<List<int>> reverseFunc = nums => nums.Reverse();
            Func<List<int>, List<int>> removeNumsFunc = numbers => numbers.Where(x => x % divNumber != 0).ToList();

            reverseFunc(inputNumbers);
            print(removeNumsFunc(inputNumbers));
        }
    }
}
