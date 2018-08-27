﻿using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CharacterMultiplier
{
    class CharacterMultiplier 
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string first = words[0];
            string second = words[1];

            int length = Math.Max(first.Length, second.Length);

            first = first.PadRight(length, '\x0001');
            second = second.PadRight(length, '\x0001');

            double result = 0.0;

            for (int i = 0; i < length; i++)
            {
                result += first[i] * second[i];
            }
            Console.WriteLine(result);
        }
    }
}
