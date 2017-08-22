using System;

namespace CardCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib = new Library();
            var book1 = new Book
            {
                Title = "The Cat In The Hat",
                Author = "Dr. Seuss",
                PublishedDate = new DateTime(1957, 3, 12),
                OverdueDate = DateTime.Now.AddDays(10),
                IsCheckedOut = false
            };
            var book2 = new Book
            {
                Title = "Oh, the Places You'll Go!",
                Author = "Dr. Seuss",
                PublishedDate = new DateTime(1990, 1, 22),
                OverdueDate = DateTime.Now.AddDays(10),
                IsCheckedOut = false
            };
            var book3 = new Book
            {
                Title = "Go The F*ck To Sleep",
                Author = "Adam Mansbach",
                PublishedDate = new DateTime(2011, 6, 11),
                OverdueDate = new DateTime(2017, 8, 21),
                IsCheckedOut = true
            };
            lib.Catalog.Add(book1);
            lib.Catalog.Add(book2);
            lib.Catalog.Add(book3);

            Console.WriteLine("Please input the author that you are searching for:");
            var authors = lib.searchForBookByAuthor(Console.ReadLine());
            foreach (var item in authors)
            {
                Console.WriteLine($"{item.Title} was written by {item.Author}.");
            }

            Console.WriteLine("Please input the book title that you are searching for:");
            var books = lib.searchForBookByName(Console.ReadLine());
            foreach (var item in books)
            {
                Console.WriteLine($"{item.Title} was written by {item.Author}.");
            }

            lib.checkIn("Go The F*ck To Sleep");
            Console.WriteLine($"Is {book3.Title} checked out? {book3.IsCheckedOut}.");

            lib.checkOut("The Cat In The Hat");
            Console.WriteLine($"Is {book1.Title} checked out? {book1.IsCheckedOut}.");

            var overdue = lib.searchOverdue();
            foreach (var item in overdue)
            {
                Console.WriteLine($"{item.Title} is currently overdue.");
            }
        }

    }
}
