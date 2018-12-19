using SoftUniRestaurant.Models.Drinks.Contracts;
using SoftUniRestaurant.Models.Foods.Contracts;
using SoftUniRestaurant.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniRestaurant.Models.Tables
{
    public abstract class Table : ITable
    {
        private List<IFood> foodOrders;
        private List<IDrink> drinkOrders;
        private int tableNumber;
        private int capacity;
        private int numberOfPeople;
        private decimal pricePerPerson;
        private bool isReserved;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;
            foodOrders = new List<IFood>();
            drinkOrders = new List<IDrink>();
            IsReserved = false;
        }

        public IReadOnlyCollection<IFood> FoodOrders => foodOrders.AsReadOnly();

        public IReadOnlyCollection<IDrink> DrinkOrders => drinkOrders.AsReadOnly();

        public int TableNumber { get => tableNumber; private set => tableNumber = value; }
        public int Capacity
        {
            get => capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }
                capacity = value;
            }
        }
        public int NumberOfPeople
        {
            get => numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }
                numberOfPeople = value;
            }
        }
        public decimal PricePerPerson { get => pricePerPerson; private set => pricePerPerson = value; }
        public bool IsReserved { get => isReserved; private set => isReserved = value; }


        public decimal Price()
        {
            decimal price = NumberOfPeople * PricePerPerson;
            return price;
        }

        public void Reserve(int numberOfPeople)
        {
            IsReserved = true;
            NumberOfPeople = numberOfPeople;
        }

        public void OrderFood(IFood food)
        {
            foodOrders.Add(food);
        }

        public void OrderDrink(IDrink drink)
        {
            drinkOrders.Add(drink);
        }

        public decimal GetBill()
        {
            decimal sumFoods = foodOrders.Sum(x => x.Price);
            decimal sumDrinks = drinkOrders.Sum(x => x.Price);
            var output = sumDrinks + sumFoods + Price();
            return output;
        }

        public void Clear()
        {
            foodOrders.RemoveAll(x=>x != null);
            drinkOrders.RemoveAll(x => x != null);
            IsReserved = false;
            numberOfPeople = 0;
        }

        public string GetFreeTableInfo()
        {
           
            StringBuilder sb = new StringBuilder();
            if (NumberOfPeople == 0)
            {
                sb.AppendLine($"Table: {TableNumber}");
                sb.AppendLine($"Type: {GetType().Name}");
                sb.AppendLine($"Capacity: {Capacity}");
                sb.AppendLine($"Price per Person: {PricePerPerson}");

            }
            return sb.ToString().TrimEnd();
        }

        public string GetOccupiedTableInfo()
        {
            StringBuilder sb = new StringBuilder();
            if (NumberOfPeople > 0)
            {
                sb.AppendLine($"Table: {TableNumber}");
                sb.AppendLine($"Type: {GetType().Name}");
                sb.AppendLine($"Number of people: {NumberOfPeople}");
                if (foodOrders.Count == 0)
                {
                    sb.AppendLine("Food orders: None");
                }
                else
                {
                    sb.AppendLine($"Food orders: {foodOrders.Count}");
                    foreach (IFood item in foodOrders)
                    {
                        sb.AppendLine(item.ToString());
                    }
                }

                if (drinkOrders.Count == 0)
                {
                    sb.AppendLine("Drink orders: None");
                }
                else
                {
                    sb.AppendLine($"Drink orders: {drinkOrders.Count}");
                    foreach (IDrink item in drinkOrders)
                    {
                        sb.AppendLine(item.ToString());
                    }
                }

            }

            return sb.ToString().TrimEnd();
        }
    }
}
