using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniRestaurant.Core
{
    public class Engine
    {
        private RestaurantController restaurantController;
        
        public Engine()
        {
            restaurantController = new RestaurantController();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    Console.WriteLine(ReadCommand(command));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
            
            Console.WriteLine(restaurantController.GetSummary());
        }

        private string ReadCommand(string command)
        {
            string[] tokens = command.Split();
            var output = string.Empty;
            string[] args = tokens.Skip(1).ToArray();

            switch (tokens[0])
            {
                case "AddFood":
                    output = restaurantController.AddFood(args[0], args[1], decimal.Parse(args[2]));
                    break;
                case "AddDrink":
                    output = restaurantController.AddDrink(args[0], args[1], int.Parse(args[2]), args[3]);
                    break;
                case "AddTable":
                    output = restaurantController.AddTable(args[0], int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "ReserveTable":
                    output = restaurantController.ReserveTable(int.Parse(args[0]));
                    break;
                case "OrderFood":
                    output = restaurantController.OrderFood(int.Parse(args[0]), args[1]);
                    break;
                case "OrderDrink":
                    output = restaurantController.OrderDrink(int.Parse(args[0]), args[1], args[2]);
                    break;
                case "LeaveTable":
                    output = restaurantController.LeaveTable(int.Parse(args[0]));
                    break;
                case "GetFreeTablesInfo":
                    output = restaurantController.GetFreeTablesInfo();
                    break;
                case "GetOccupiedTablesInfo":
                    output = restaurantController.GetOccupiedTablesInfo();
                    break;

            }
            return output;
        }
    }
}
