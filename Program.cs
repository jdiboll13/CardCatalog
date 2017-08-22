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
                IsCheckedOut = false
            };
            var book2 = new Book
            {
                Title = "Oh, the Places You'll Go!",
                Author = "Dr. Seuss",
                PublishedDate = new DateTime(1990, 1, 22),
                IsCheckedOut = false
            };
            lib.Catalog.Add(book1);
            lib.Catalog.Add(book2);
            
        }
        
    }
}
