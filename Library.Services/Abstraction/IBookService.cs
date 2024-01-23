using Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Abstraction
{
    public interface IBookService
    {
        public List<Book> GetBooks();
        public Book GetBookById(int id);
    }
}
