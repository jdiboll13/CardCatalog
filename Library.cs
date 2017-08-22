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
            var searchedName = Catalog.Where(w => w.Title.ToLower().Contains(name.ToLower()));
            return searchedName;
        }
        public IEnumerable<Book> searchForBookByAuthor(string name)
        {
            var searchedAuthor = Catalog.Where(w => w.Author.ToLower().Contains(name.ToLower()));
            return searchedAuthor;
        }
        public IEnumerable<Book> searchOverdue()
        {
            var searchOverdue = Catalog.Where(w => w.OverdueDate <= DateTime.Now);
            return searchOverdue;
        }
        public void checkedOut(string title, string membername)
        {
            var searchedCheckedOut = Catalog.FirstOrDefault(w => w.Title == title);
            if (searchedCheckedOut.IsCheckedOut == true)
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