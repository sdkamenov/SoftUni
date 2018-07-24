using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();

            Console.WriteLine(string.Join(" ", list.Take(3)));
        }
    }
}
