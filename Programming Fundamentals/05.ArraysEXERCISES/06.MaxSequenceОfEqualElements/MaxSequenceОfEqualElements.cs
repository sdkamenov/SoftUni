using System;
using System.Linq;

namespace MaxSequenceОfEqualElements
{
    class MaxSequenceОfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int digitToPrint = 0;
            int maxLenght = 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentIndex = arr[i];
                int currentLenght = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentLenght++;
                        if (maxLenght < currentLenght)
                        {
                            maxLenght = currentLenght;
                            digitToPrint = currentIndex;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < maxLenght; i++)
            {
                Console.Write(digitToPrint + " ");
            }
        }
    }
}
