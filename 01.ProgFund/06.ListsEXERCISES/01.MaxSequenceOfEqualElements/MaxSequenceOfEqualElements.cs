using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxNumber = numbers[0];
            int maxCount = 1;
            int counter = 1;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        maxNumber = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }


            }

            //foreach (int num1 in numbers)
            //{
            //    int counter = 0;
            //    foreach (var num2 in numbers)
            //    {
            //        if (num1 == num2)
            //        {
            //            counter++;
            //        }
            //    }

            //    if (counter > maxCount)
            //    {
            //        maxCount = counter;
            //        maxNumber = num1;
            //    }

            //}

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxNumber} ");
            }
        }
    }
}
