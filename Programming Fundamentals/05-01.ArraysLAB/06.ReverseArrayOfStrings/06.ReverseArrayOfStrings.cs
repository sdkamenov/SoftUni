using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //var arr = Console.ReadLine().Split(' ').ToArray();
            //for (int i = 0; i < arr.Length/2; i++)
            //{
            //    SwapElements(arr, i, arr.Length - 1 - i);
            //}
            //Console.WriteLine(string.Join(" ", arr));
        }

        // static void SwapElements(string[] arr, int i, int j)
        //{
        //    var temp = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = temp;
        //}
    }
}
