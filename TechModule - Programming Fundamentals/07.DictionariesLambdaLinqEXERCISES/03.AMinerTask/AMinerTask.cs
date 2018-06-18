using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                //if (resources.ContainsKey(resource))
                //{
                //    resources[resource] += quantity;
                //}
                //else
                //{
                //    resources.Add(resource, quantity);
                //}

                if (resources.ContainsKey(resource) == false)
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
