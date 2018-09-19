using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum());
            
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //int sum = 0;

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    List<char> num = numbers[i].ToString().ToList();
            //    num.Reverse();
            //    sum += int.Parse(string.Join("", num));
            //}
            //Console.WriteLine(sum);
        }
    }
}
