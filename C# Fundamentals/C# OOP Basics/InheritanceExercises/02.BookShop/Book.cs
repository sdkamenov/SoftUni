﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02.BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title
        {
            get => title;

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }
        public string Author
        {
            get => author;

            set
            {
                string[] fullName = value.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (fullName.Length > 1)
                {
                    string lastName = fullName[1];
                    if (char.IsDigit(lastName[0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                author = value;
            }
        }
        public virtual decimal Price
        {
            get => price;

            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .Append($"Price: {this.Price:F2}");

            return sb.ToString();
        }
    }
}
