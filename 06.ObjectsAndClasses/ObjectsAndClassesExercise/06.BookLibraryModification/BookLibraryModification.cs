namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library("My Library", new List<Book>());
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] bookArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string title = bookArgs[0];
                string author = bookArgs[1];
                string publisher = bookArgs[2];
                DateTime releaseDate = DateTime.ParseExact(bookArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = bookArgs[4];
                double price = double.Parse(bookArgs[5]);
                Book newBook = new Book(title, author, publisher, releaseDate, isbn, price);
                library.ListOfBooks.Add(newBook);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            IList<Book> booksAfterGivenDate = library.GetBooksAfterDate(date)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title)
                .ToList();
            foreach (var book in booksAfterGivenDate)
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
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

        public IList<Book> GetBooksAfterDate(DateTime date)
        {
            return this.ListOfBooks.Where(b => b.ReleaseDate.CompareTo(date) == 1).ToList();
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