using Library.Domain;
using Library.Repostories.Abstraction;
using Library.Services.Abstraction;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
                
        }
        public List<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }
    }
}
