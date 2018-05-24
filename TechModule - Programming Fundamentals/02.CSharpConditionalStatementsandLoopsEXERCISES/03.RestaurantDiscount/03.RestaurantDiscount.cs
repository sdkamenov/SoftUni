using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName;
            double pricePerPerson = 0;
            double totalPrice = 0;

            if (people <= 50)
            {
                hallName = "Small Hall";
                if (package == "Normal")
                {
                    totalPrice = 2500.0 + 500.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.05)) / people;
                }
                else if (package == "Gold")
                {
                    totalPrice = 2500.0 + 750.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.10)) / people;
                }
                else if (package == "Platinum")
                {
                    totalPrice = 2500.0 + 1000.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.15)) / people;
                }
                Console.WriteLine($"We can offer you the {hallName}{Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            else if (people > 50 && people <= 100)
            {
                hallName = "Terrace";
                if (package == "Normal")
                {
                    totalPrice = 5000.0 + 500.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.05)) / people;
                }
                else if (package == "Gold")
                {
                    totalPrice = 5000.0 + 750.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.10)) / people;
                }
                else if (package == "Platinum")
                {
                    totalPrice = 5000.0 + 1000.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.15)) / people;
                }
                Console.WriteLine($"We can offer you the {hallName}{Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            else if  (people > 100 && people <= 120)
            {
                hallName = "Great Hall";
                if (package == "Normal")
                {
                    totalPrice = 7500.0 + 500.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.05)) / people;
                }
                else if (package == "Gold")
                {
                    totalPrice = 7500.0 + 750.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.10)) / people;
                }
                else if (package == "Platinum")
                {
                    totalPrice = 7500.0 + 1000.0;
                    pricePerPerson = (totalPrice - (totalPrice * 0.15)) / people;
                }
                Console.WriteLine($"We can offer you the {hallName}{Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
