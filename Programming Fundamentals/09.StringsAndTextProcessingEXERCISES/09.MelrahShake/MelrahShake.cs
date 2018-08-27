using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = Console.ReadLine();

            while (true)
            {
                int firstIndex = input.IndexOf(key);
                int lastIndex = input.LastIndexOf(key);

                if (firstIndex == -1 || firstIndex == lastIndex || key == string.Empty)
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                input = input.Remove(lastIndex, key.Length);
                input = input.Remove(firstIndex, key.Length);
                key = key.Remove(key.Length / 2, 1);
                Console.WriteLine("Shaked it.");
            }

            Console.WriteLine(input);
        }
    }
}
