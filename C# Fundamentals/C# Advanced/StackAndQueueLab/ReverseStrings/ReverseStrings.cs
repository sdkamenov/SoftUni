using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var charr in input)
            {
                stack.Push(charr);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop().ToString());
            }

            Console.WriteLine();
        }
    }
}
