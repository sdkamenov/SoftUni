using System;

namespace Problem02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            double totalMoney = amount;
            string game = Console.ReadLine();
            double gamePrice = 0;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case ("OutFall 4"):
                        gamePrice = 39.99;
                        if (amount >= gamePrice)
                        {
                            amount -= gamePrice;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case ("CS: OG"):
                        gamePrice = 15.99;
                        if (amount >= gamePrice)
                        {
                            amount -= gamePrice;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case ("Zplinter Zell"):
                        gamePrice = 19.99;
                        if (amount >= gamePrice)
                        {
                            amount -= gamePrice;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case ("Honored 2"):
                        gamePrice = 59.99;
                        if (amount >= gamePrice)
                        {
                            amount -= gamePrice;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case ("RoverWatch"):
                        gamePrice = 29.99;
                        if (amount >= gamePrice)
                        {
                            amount -= gamePrice;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case ("RoverWatch Origins Edition"):
                        gamePrice = 39.99;
                        if (amount >= gamePrice)
                        {
                            amount -= gamePrice;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (amount <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }
            double remainingMoney = totalMoney - amount;
            Console.WriteLine($"Total spent: ${remainingMoney:f2}. Remaining: ${amount:f2}");
        }
    }
}

/* dictionary solution
 namespace _2.Vapor_Store
{
    using System;
    using System.Collections.Generic;
 
    public class Program
    {
        public static void Main()
        {
            var currentBalance = decimal.Parse(Console.ReadLine());
 
            var totalMoney = currentBalance;
           
            var buyingOrder = Console.ReadLine();
 
            var gamesDictionary = new Dictionary<string, decimal>()
            {
                {"OutFall 4" , 39.99m},
                {"CS: OG" , 15.99m},
                {"Zplinter Zell" , 19.99m},
                {"Honored 2" , 59.99m},
                {"RoverWatch" , 29.99m},
                {"RoverWatch Origins Edition" , 39.99m},
            };
 
            var isGamePresent = false;
 
            while (buyingOrder != "Game Time")
            {
 
                foreach (var game in gamesDictionary)
                {
                    if (game.Key == buyingOrder)
                    {
                        isGamePresent = true;
 
                        if (currentBalance >= game.Value)
                        {
                            currentBalance -= game.Value;
                            Console.WriteLine($"Bought {game.Key}");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");  
                        }
                        if (currentBalance == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }                                            
                    }                  
                }
 
                if (!isGamePresent)
                {
                    Console.WriteLine("Not Found");
                }
 
                buyingOrder = Console.ReadLine();
                isGamePresent = false;
            }
 
            var remainingMoney = totalMoney - currentBalance;
            Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     */
