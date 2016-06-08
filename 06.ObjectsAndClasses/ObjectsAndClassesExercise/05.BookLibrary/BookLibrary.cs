namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library("My Library", new List<Book>());
            Dictionary<string, double> authorPricesByAuthor = new Dictionary<string, double>();
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] bookArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string title = bookArgs[0];
                string author = bookArgs[1];
                string publisher = bookArgs[2];
                DateTime releaseDate = DateTime.Parse(bookArgs[3]);
                string isbn = bookArgs[4];
                double price = double.Parse(bookArgs[5]);
                Book newBook = new Book(title, author, publisher, releaseDate, isbn, price);
                library.ListOfBooks.Add(newBook);
                double totalAuthorPrice = library.CalculateTotalAuthorPrice(author);
                if (!authorPricesByAuthor.ContainsKey(author))
                {
                    authorPricesByAuthor.Add(author, 0);
                }

                authorPricesByAuthor[author] = totalAuthorPrice;
            }

            authorPricesByAuthor = authorPricesByAuthor
                .OrderByDescending(b => b.Value)
                .ThenBy(b => b.Key)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var entry in authorPricesByAuthor)
            {
                Console.WriteLine("{0} -> {1:F2}", entry.Key, entry.Value);
            }
        }
    }

    public class Library
    {
        public Library(string name, IList<Book> books)
        {
            this.Name = name;
            this.ListOfBooks = books;
        }

        public string Name { get; set; }

        public IList<Book> ListOfBooks { get; set; }

        public double CalculateTotalAuthorPrice(string authorName)
        {
            double totalPrice = this.ListOfBooks
                .Where(b => b.Author == authorName)
                .Sum(b => b.Price);

            return totalPrice;
        }
    }

    public class Book
    {
        public Book(string title, string author, string publisher, DateTime release, string isbn, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = release;
            this.ISBNNumber = isbn;
            this.Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBNNumber { get; set; }

        public double Price { get; set; }
    }
}