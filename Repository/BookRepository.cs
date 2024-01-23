using Library.Domain;
using Library.Repostories.Abstraction;

namespace Library.Repostories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetBooks()
        {
            // Get all books from db
             List<Book>  books = new List<Book>();
            for (int i = 0; i < 10; i++) { 
                var book = new Book();
                book.Title = $"Book Title: {i.ToString()}";
                book.id = i;
                books.Add(book);
            }

            return books;
        }
        public Book GetBookById(int id)
        {
            // Get all books from db
            
                var book = new Book();
                book.Title = $"Book Title: Test {id}";
                book.id = id;
               
            

            return book;
        }
    }
}
