using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET.Model;
using RestWithASPNET.Bussines;

namespace RestWithASPNET.Controllers
{
    [ApiController]   
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBooksBussines _BooksBussines;

        public BooksController(ILogger<BooksController> logger, IBooksBussines BooksBussines)
        {
            _logger = logger;
            _BooksBussines = BooksBussines;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_BooksBussines.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(long id)
        {
            var book = _BooksBussines.FindById(id);
            if (book is null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] Book book)
        {
            if (book is null)
                return BadRequest();
            return Ok(_BooksBussines.Create(book));
        }

        [HttpPut]
        public IActionResult UpdateBook([FromBody] Book book)
        {
            if (book is null)
                return BadRequest();
            return Ok(_BooksBussines.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(long id)
        {
            _BooksBussines.Delete(id);
            return NoContent();
        }
    }
}
