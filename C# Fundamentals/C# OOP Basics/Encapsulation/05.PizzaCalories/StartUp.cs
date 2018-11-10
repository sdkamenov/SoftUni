using System;
using System.Collections.Generic;

namespace _05.PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] == "Pizza")
                {
                    pizza.Name = input[1];
                }
                else if (input[0] == "Dough")
                {
                    string flour = input[1].ToLower();
                    string bakingTech = input[2].ToLower();
                    int weight = int.Parse(input[3]);
                    Dough dough = new Dough(flour, bakingTech, weight);
                    pizza.Dough = dough;
                }
                else if (input[0] == "Topping")
                {
                    string toppingType = input[1].ToLower();
                    int weight = int.Parse(input[2]);
                    Toppings topping = new Toppings(toppingType, weight);
                    pizza.Add(topping);
                    if (pizza.Toppings.Count > 10)
                    {
                        Exception ex = new ArgumentException("Number of toppings should be in range [0..10].");
                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine(pizza);
        }
    }
}
