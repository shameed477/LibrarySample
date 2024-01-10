using Library.Domain;
using Library.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet(Name = "GetBooks")]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetBooks();
        }
    }
}
