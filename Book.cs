using System;

namespace CardCatalog
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime OverdueDate { get; set; }
        public bool IsCheckedOut { get; set; }
        public Member WhoCheckedOut { get; set; }
        public Book(){}
    }
}