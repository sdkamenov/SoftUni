using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            char[] openBracket = new char[] { '{', '[', '(' };
            var stack = new Stack<char>();
            bool isValid = true;


            for (int i = 0; i < parenthesis.Length; i++)
            {
                char currentBracket = parenthesis[i];

                if (openBracket.Contains(currentBracket))
                {
                    stack.Push(currentBracket);
                    continue;
                }

                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stack.Peek() == '(' && currentBracket == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && currentBracket == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && currentBracket == '}')
                {
                    stack.Pop();
                }
            }

            if (isValid && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
