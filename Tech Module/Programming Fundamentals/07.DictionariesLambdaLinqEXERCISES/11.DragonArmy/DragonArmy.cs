using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string type = tokens[0];
                string name = tokens[1];

                decimal dmg = 0m;
                if (tokens[2] != "null")
                {
                    dmg = decimal.Parse(tokens[2]);
                }
                else
                {
                    dmg = 45;
                }


                decimal health = 0m;
                if (tokens[3] != "null")
                {
                    health = decimal.Parse(tokens[3]);
                }
                else
                {
                    health = 250;
                }

                decimal armor = 0m;
                if (tokens[4] != "null")
                {
                    armor = decimal.Parse(tokens[4]);
                }
                else
                {
                    armor = 10;
                }
                
                // ugly ternary
                // var damage = tokens[2] != "null" ? decimal.Parse(tokens[2]) : 45;
                // var health = tokens[3] != "null" ? decimal.Parse(tokens[3]) : 250;
                // var armor = tokens[4] != "null" ? decimal.Parse(tokens[4]) : 10;

                if (dragons.ContainsKey(type) == false)
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { dmg, health, armor };
            }

            foreach (var type in dragons)
            {
                var typeName = type.Key; //string
                var dragonType = type.Value; //sortedD<string, decimal>

                var averageDmg = dragonType.Values.Average(x => x[0]);
                var averageHealth = dragonType.Values.Average(x => x[1]);
                var averageArmor = dragonType.Values.Average(x => x[2]);

                Console.WriteLine($"{typeName}::({averageDmg:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonType)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
