using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumber
{
    class CountRealNumber
    {
        static void Main(string[] args)
        {
            //List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            //list.Sort();
            //List<double> numbers = new List<double>();
            //List<int> count = new List<int>();

            //foreach (var num in list)
            //{
            //    if (numbers.Contains(num) == false)
            //    {
            //        numbers.Add(num);
            //        count.Add(1);
            //    }
            //    else
            //    {
            //        int index = numbers.IndexOf(num);
            //        count[index]++;
            //    }
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine($"{numbers[i]} -> {count[i]}");
            //}

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (!numbers.ContainsKey(num))
                {
                    numbers.Add(num, 0);
                }
                numbers[num]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
