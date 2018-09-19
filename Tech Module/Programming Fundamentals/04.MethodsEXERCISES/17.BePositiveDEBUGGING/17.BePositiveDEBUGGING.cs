﻿using System;
using System.Collections.Generic;

namespace BePositiveDEBUGGING
{
    class BePositiveDEBUGGING
    {
        static void Main(string[] args)
        {
            //int countSequences = int.Parse(Console.ReadLine());

            //for (int i = 0; i < countSequences; i++)
            //{
            //    string[] input = Console.ReadLine().Trim().Split(' ');
            //    var numbers = new List<int>();

            //    for (int j = 0; j < input.Length; j++)
            //    {
            //        if (!input[j].Equals(string.Empty))
            //        {
            //            int num = int.Parse(input[i]);
            //            numbers.Add(num);
            //        }
            //    }

            //    bool found = false;

            //    for (int j = 0; j < numbers.Count; j++)
            //    {
            //        int currentNum = numbers[j];

            //        if (currentNum > 0)
            //        {
            //            if (found)
            //            {
            //                Console.Write(" ");
            //            }

            //            Console.Write(currentNum);

            //            found = true;
            //        }
            //        else
            //        {
            //            currentNum += numbers[j + 1];

            //            if (currentNum > 0)
            //            {
            //                if (found)
            //                {
            //                    Console.Write(" ");
            //                }

            //                Console.Write(currentNum);

            //                found = true;
            //            }
            //        }
            //    }

            //    if (!found)
            //    {
            //        Console.WriteLine("(empty)");
            //    }
            //}
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        if (!(j == numbers.Count - 1))
                        {
                            currentNum += numbers[j + 1];
                            numbers.RemoveAt(j + 1);
                            if (currentNum >= 0)
                            {
                                if (found)
                                {
                                    Console.Write(" ");
                                }

                                Console.Write(currentNum);

                                found = true;
                            }
                        }
                    }
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }

                Console.WriteLine();
            }
        }
    }
}
