using System;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoRoundhouseKick = int.Parse(Console.ReadLine());
            int goshoThunderousFist = int.Parse(Console.ReadLine());
            int healthGosho = 100;
            int healthPesho = 100;
            int counterAttackRound = 1;

            while (true)
            {
                if (counterAttackRound % 2 == 1)
                {
                    healthGosho -= peshoRoundhouseKick;

                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counterAttackRound}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }
                }
                else
                {
                    healthPesho -= goshoThunderousFist;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {counterAttackRound}th round.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }
                }

                if (counterAttackRound % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
                counterAttackRound++;
            }

        }
    }
}
/* not so different solution:
using System;

namespace _15.Neighbour_Wars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int attackCounter = 0;

            bool isAnyoneAlive = true;
            string attackName = string.Empty;
            string attacker = string.Empty;
            string attacked = string.Empty;
            int attackedHealth = 0;


            while (isAnyoneAlive)
            {
                attackCounter++;
                if (attackCounter % 2 != 0)
                {
                    goshosHealth -= peshosDamage;
                    attackName = "Roundhouse kick";
                    attacker = "Pesho";
                    attacked = "Gosho";
                    attackedHealth = goshosHealth;
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    attackName = "Thunderous fist";
                    attacker = "Gosho";
                    attacked = "Pesho";
                    attackedHealth = peshosHealth;
                }
                if (peshosHealth <= 0 || goshosHealth <= 0)
                {
                    Console.WriteLine($"{attacker} won in {attackCounter}th round.");
                    isAnyoneAlive = false;
                }
                else
                {
                    if (attackCounter % 3 == 0)
                    {
                        goshosHealth += 10;
                        peshosHealth += 10;
                    }
                    Console.WriteLine($"{attacker} used {attackName} and reduced {attacked} to {attackedHealth} health.");
                }
            }
        }
    }
}
*/
