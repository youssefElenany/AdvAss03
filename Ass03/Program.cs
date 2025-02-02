using AdvAss03;
using static AdvAss03.Book;

namespace Ass03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryEngine library = new LibraryEngine();

            Book book1 = new Book("The C# Journey", "John Doe", "123-456-789", new DateTime(2020, 5, 10),3000);
            Book book2 = new Book("Mastering ASP.NET", "Jane Smith", "987-654-321", new DateTime(2021, 11, 25),4000);

            library.AddBook(book1);
            library.AddBook(book2);

            library.DisplayBookDetails();

        }
    }
}
