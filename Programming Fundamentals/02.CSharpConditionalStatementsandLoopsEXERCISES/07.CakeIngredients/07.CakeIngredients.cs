using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string ingredient = Console.ReadLine();
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count += 1;

                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
