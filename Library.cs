using System;
using System.Collections.Generic;
using System.Linq;

namespace CardCatalog
{
    class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Catalog = new List<Book>();
        public IEnumerable<Book> searchForBookByName(string name)
        {
            var search = Catalog.Where(w => w.Title.ToLower().Contains(name.ToLower()));
            return search;
        }
        public IEnumerable<Book> searchForBookByAuthor(string name)
        {
            var search = Catalog.Where(w => w.Author.ToLower().Contains(name.ToLower()));
            return search;
        }
        public IEnumerable<Book> searchOverdue()
        {
            var search = Catalog.Where(w => w.OverdueDate <= DateTime.Now);
            return search;
        }
        public void checkedOut(string title, string membername)
        {
            var search = Catalog.FirstOrDefault(w => w.Title == title);
            if (search?.IsCheckedOut == true)
            {
                Console.WriteLine("I'm sorry. That book is currently checked out.");
            }
            else
            {
                Console.WriteLine("That title is available for you to check out.");
            }
        }

    }
}