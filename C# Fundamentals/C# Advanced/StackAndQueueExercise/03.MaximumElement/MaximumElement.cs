using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];

                if (command == "1")
                {
                    stack.Push(int.Parse(input[1]));
                }
                else if (command == "2")
                {
                    stack.Pop();
                }
                else if (command == "3")
                {
                    int maxNum = stack.ToArray().Max();
                    Console.WriteLine(maxNum);
                }
            }
        }
    }
}
