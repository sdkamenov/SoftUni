using System;
using System.Linq;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int minLenght = Math.Min(firstArray.Length, secondArray.Length);

            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine(string.Join("", secondArray));
                        Console.WriteLine(string.Join("", firstArray));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstArray));
                        Console.WriteLine(string.Join("", secondArray));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minLenght; i++)
                {
                    if (firstArray.Length > secondArray.Length)
                    {
                        if (firstArray[i] == secondArray[i])
                        {
                            Console.WriteLine(string.Join("", secondArray));
                            Console.WriteLine(string.Join("", firstArray));
                            break;
                        }
                        else if (firstArray[i] > secondArray[i])
                        {
                            Console.WriteLine(string.Join("", secondArray));
                            Console.WriteLine(string.Join("", firstArray));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", firstArray));
                            Console.WriteLine(string.Join("", secondArray));
                            break;
                        }
                    }
                    else if (firstArray.Length < secondArray.Length)
                    {
                        if (firstArray[i] == secondArray[i])
                        {
                            Console.WriteLine(string.Join("", firstArray));
                            Console.WriteLine(string.Join("", secondArray));
                            break;
                        }
                        else if (firstArray[i] > secondArray[i])
                        {
                            Console.WriteLine(string.Join("", firstArray));
                            Console.WriteLine(string.Join("", secondArray));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", secondArray));
                            Console.WriteLine(string.Join("", firstArray));
                            break;
                        }
                    }
                }
            }
        }
    }
}
