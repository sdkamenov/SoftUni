using System;
using System.Linq;
using System.Collections.Generic;

namespace InfernoIII
{
    class InfernoIII
    {
        static void Main(string[] args)
        {
            Action<List<int>> print = p => Console.WriteLine(string.Join(" ", p));
            var filters = new Dictionary<string, Dictionary<int, Func<int, int, bool>>>();
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Forge")
                {
                    break;
                }

                string[] tokens = input.Split(";");
                string command = tokens[0];
                string functionName = tokens[1];
                int value = int.Parse(tokens[2]);
                Func<int, int, bool> sumFun = GetFunction(numbers, functionName);

                if (command == "Exclude")
                {
                    if (!filters.ContainsKey(functionName))
                    {
                        filters.Add(functionName, new Dictionary<int, Func<int, int, bool>>());
                    }

                    if (!filters[functionName].ContainsKey(value))
                    {
                        filters[functionName].Add(value, sumFun);
                    }

                }
                else
                {
                    if (filters.ContainsKey(functionName))
                    {
                        filters[functionName].Remove(value);
                    }
                }

            }

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool isValid = true;

                foreach (var filter in filters)
                {
                    foreach (var kvp in filter.Value)
                    {
                        if (kvp.Value(i, kvp.Key))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    result.Add(numbers[i]);
                }
            }

            print(result);
        }

        private static Func<int, int, bool> GetFunction(List<int> numbers, string functionName)
        {
            if (functionName == "Sum Left")
            {
                return (a, b) => a == 0 ? numbers[a] == b : numbers[a] + numbers[a - 1] == b;
            }
            else if (functionName == "Sum Right")
            {
                return (a, b) => a == numbers.Count - 1 ? numbers[a] == b : numbers[a] + numbers[a + 1] == b;
            }
            else if (functionName == "Sum Left Right")
            {
                return (a, b) => numbers.Count == 1 ? numbers[a] == b :
                                 a == numbers.Count - 1 ? numbers[a - 1] + numbers[a] == b :
                                 a == 0 ? numbers[a] + numbers[a + 1] == b :
                                 numbers[a - 1] + numbers[a] + numbers[a + 1] == b;
            }
            return null;
        }
    }
}
