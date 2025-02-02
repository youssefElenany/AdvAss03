using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvAss03
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }

        public Book(string title, string author, string isbn, DateTime publicationDate , decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
            Price = price;
        }
        public class BookFunctions
        {
            
            public delegate string BookInfoDelegate(Book book);

            
            public Func<Book, string> GetAuthor;
            public Action<Book> DisplayTitle;

            
            public BookInfoDelegate GetISBN;

            
            public Func<Book, DateTime> GetPublicationDate;

            public Func<Book, decimal> GetPrice; 

            public BookFunctions()
            {
               
                GetISBN = delegate (Book book)
                {
                    return book.ISBN;
                };

                
                GetAuthor = (book) => book.Author;
                DisplayTitle = (book) => Console.WriteLine($"Title: {book.Title}");

                
                GetPublicationDate = (book) => book.PublicationDate;

                GetPrice = (book) => book.Price;

            }
        }
        public class LibraryEngine
        {
            private List<Book> books = new List<Book>();
            private BookFunctions bookFunctions = new BookFunctions();

            public void AddBook(Book book)
            {
                books.Add(book);
            }

            public void DisplayBookDetails()
            {
                foreach (var book in books)
                {
                    bookFunctions.DisplayTitle(book);
                    Console.WriteLine($"Author: {bookFunctions.GetAuthor(book)}");
                    Console.WriteLine($"ISBN: {bookFunctions.GetISBN(book)}");
                    Console.WriteLine($"Publication Date: {bookFunctions.GetPublicationDate(book):yyyy-MM-dd}");
                    Console.WriteLine($"Price:{bookFunctions.GetPrice(book)}");
                    Console.WriteLine(new string('-', 30));
                }
            }
        }

    }

}
