using System;

namespace ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            string[] inputNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            void print(string[] names) => Console.WriteLine(string.Join("\n", names));

            print(inputNames);
        }
    }
}
