using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            string[] words = Console.ReadLine().ToLower().Split(separators).ToArray();
            var result = words.Where(w => w != "").Where(w => w.Length < 5).OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ",  result));
        }
    }
}
