using Casodistudio.Entities;
using Casodistudio.Service;
using Microsoft.AspNetCore.Mvc;

namespace Casodistudio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        public async Task<ActionResult<Book>> GetAll()
        {
            List<Book> books = bookService.GetAll();

            return Ok(books);
        }
    }
}