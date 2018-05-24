using System;

namespace Problem07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfItemsToBuy = int.Parse(Console.ReadLine());
            decimal subTotal = 0m;


            for (int i = 1; i <= numberOfItemsToBuy; i++)
            {
                string itemName = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                if (count == 1)
                {
                    Console.WriteLine($"Adding {count} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {count} {itemName}s to cart.");
                }

                subTotal += price * count;
            }
            Console.WriteLine($"Subtotal: ${subTotal:f2}");

            if (budget >= subTotal)
            {
                Console.WriteLine($"Money left: ${(budget - subTotal):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(subTotal - budget):f2} more.");
            }

        }
    }
}
