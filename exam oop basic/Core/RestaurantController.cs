namespace SoftUniRestaurant.Core
{
    using SoftUniRestaurant.Models.Drinks;
    using SoftUniRestaurant.Models.Drinks.Contracts;
    using SoftUniRestaurant.Models.Foods;
    using SoftUniRestaurant.Models.Foods.Contracts;
    using SoftUniRestaurant.Models.Tables;
    using SoftUniRestaurant.Models.Tables.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RestaurantController
    {
        private List<IFood> menu;
        private List<IDrink> drinks;
        private List<ITable> tables;
        private decimal totalSum;
        public RestaurantController()
        {
            menu = new List<IFood>();
            drinks = new List<IDrink>();
            tables = new List<ITable>();
        }
        public string AddFood(string type, string name, decimal price)
        {
            IFood food = null;
            string output = string.Empty;
            if (type == "Dessert")
            {
                food = new Dessert(name, price);
                menu.Add(food);
                output = $"Added {name} ({type}) with price {price:f2} to the pool";
            }
            else if (type == "MainCourse")
            {
                food = new MainCourse(name, price);
                menu.Add(food);
                output = $"Added {name} ({type}) with price {price:f2} to the pool";
            }
            else if (type == "Salad")
            {
                food = new Salad(name, price);
                menu.Add(food);
                output = $"Added {name} ({type}) with price {price:f2} to the pool";
            }
            else if (type == "Soup")
            {
                food = new Soup(name, price);
                menu.Add(food);
                output = $"Added {name} ({type}) with price {price:f2} to the pool";
            }
            return output;
        }

        public string AddDrink(string type, string name, int servingSize, string brand)
        {
            IDrink drink = null;
            string output = string.Empty;
            if (type == "Alcohol")
            {
                drink = new Alcohol(name, servingSize, brand);
                drinks.Add(drink);
                output = $"Added {name} ({brand}) to the drink pool";
            }
            else if (type == "FuzzyDrink")
            {
                drink = new FuzzyDrink(name, servingSize, brand);
                drinks.Add(drink);
                output = $"Added {name} ({brand}) to the drink pool";
            }
            else if (type == "Juice")
            {
                drink = new Juice(name, servingSize, brand);
                drinks.Add(drink);
                output = $"Added {name} ({brand}) to the drink pool";
            }
            else if (type == "Water")
            {
                drink = new Water(name, servingSize, brand);
                drinks.Add(drink);
                output = $"Added {name} ({brand}) to the drink pool";
            }
            return output;
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            
            string output = string.Empty;
            if (type == "Inside")
            {
                var table = new InsideTable(tableNumber, capacity);
                tables.Add(table);
                output = $"Added table number {table.TableNumber} in the restaurant";
            }
            else if (type == "Outside")
            {
                var table = new OutsideTable(tableNumber, capacity);
                tables.Add(table);
                output = $"Added table number {table.TableNumber} in the restaurant";
            }
            return output;
        }

        public string ReserveTable(int numberOfPeople)
        {
            var table = tables
                .Any(x => x.IsReserved == false);

            if (!table)
            {
                return $"No available table for {numberOfPeople} people";
            }
            var tb = tables.Where(x => x.Capacity >= numberOfPeople).ToArray();
            var tbb = tb.Where(x => x.NumberOfPeople == 0).First();
            ((Table)tbb).Reserve(numberOfPeople);
            return $"Table {tbb.TableNumber} has been reserved for {numberOfPeople} people";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var table = tables.Any(x => x.TableNumber == tableNumber);
            var food = menu.Any(x => x.Name == foodName);
            if (table == false)
            {
                return $"Could not find table with {tableNumber}";
            }
            if (food == false)
            {
                return $"No {foodName} in the menu";
            }
            var tb = tables.First(x => x.TableNumber == tableNumber);
            var fd = menu.First(x => x.Name == foodName);
            ((Table)tb).OrderFood(fd);
            return $"Table {tableNumber} ordered {foodName}";
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var table = tables.Any(x => x.TableNumber == tableNumber);
            var drink = drinks.Any(x => x.Name == drinkName);
            if (table == false)
            {
                return $"Could not find table with {tableNumber}";
            }
            if (drink == false)
            {
                return $"There is no {drinkName} {drinkBrand} available";
            }
            var tb = tables.First(x => x.TableNumber == tableNumber);
            var dr = drinks.First(x => x.Name == drinkName);
            ((Table)tb).OrderDrink(dr);
            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
        }

        public string LeaveTable(int tableNumber)
        {
            var table = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            var bill = ((Table)table).GetBill();

            totalSum += bill;
            ((Table)table).Clear();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {bill:f2}");
            return sb.ToString().TrimEnd();

        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in tables.Where(x=>x.NumberOfPeople == 0))
            {
                sb.AppendLine(((Table)item).GetFreeTableInfo());
            }
            return sb.ToString().TrimEnd();
        }

        public string GetOccupiedTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in tables.Where(x => x.NumberOfPeople > 0))
            {
                sb.AppendLine(((Table)item).GetOccupiedTableInfo());
            }
            return sb.ToString().TrimEnd();
        }

        public string GetSummary()
        {
            return $"Total income: {totalSum}lv";
        }
    }
}
