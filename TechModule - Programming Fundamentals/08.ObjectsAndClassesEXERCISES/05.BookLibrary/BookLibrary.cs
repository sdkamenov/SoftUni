using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);
                books.Add(book);
            }

            var authors = new Dictionary<string, decimal>();

            foreach (var book in books)
            {
                string authorName = book.Author;
                decimal price = book.Price;

                if (authors.ContainsKey(authorName) == false)
                {
                    authors.Add(authorName, price);
                }
                else
                {
                    authors[authorName] += price;
                }
            }

            Dictionary<string, decimal> sorted = authors.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(x=>x.Key, x=> x.Value);

            foreach (var author in sorted)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }

        }
    }

    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }
}
