using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("-");
                string productName = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                Product product = products
                    .FirstOrDefault(x => x.Name == productName);

                if (product == null)
                {
                    Product newProduct = new Product(productName, price);
                    products.Add(newProduct);
                }
                else
                {
                    product.Price = price;
                }
            }

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of clients")
                {
                    break;
                }

                string[] tokens = input.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string customerName = tokens[0];
                string productName = tokens[1];
                int productQuantity = int.Parse(tokens[2]);

                if (products.Any(x => x.Name == productName) == false)
                {
                    continue;
                }

                Customer customer = customers.FirstOrDefault(x => x.Name == customerName);

                if (customer == null)
                {
                    Customer newCustomer = new Customer(customerName);
                    newCustomer.OrderedProducts.Add(productName, productQuantity);
                    customers.Add(newCustomer);
                }
                else
                {
                    if (customer.OrderedProducts.ContainsKey(productName) == false)
                    {
                        customer.OrderedProducts.Add(productName, productQuantity);
                    }
                    else
                    {
                        customer.OrderedProducts[productName] += productQuantity;
                    }
                }
            }

            decimal totalBill = 0;

            foreach (var customer in customers.OrderBy(x=>x.Name))
            {
                Console.WriteLine(customer.Name);
                decimal bill = 0;
                foreach (var orderedProduct in customer.OrderedProducts)
                {
                    Console.WriteLine($"-- {orderedProduct.Key} - {orderedProduct.Value}");
                    string productName = orderedProduct.Key;
                    int quantity = orderedProduct.Value;

                    decimal price = products.First(x => x.Name == productName).Price;

                    bill += quantity * price;
                }

                totalBill += bill;

                Console.WriteLine($"Bill: {bill:f2}");
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }

    class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Customer
    {
        public Customer(string name)
        {
            Name = name;
            OrderedProducts = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<String, int> OrderedProducts { get; set; }
    }
}