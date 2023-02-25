using Asp.Net_Task.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> _book = new List<Book>();
        [HttpGet]
        public IActionResult GetAll()
        {
            if (_book != null)
            {
                return Ok(_book);
            }
            return NotFound();
        }

        [HttpGet]
        public Book Get(string id)
        {
            var get = _book.FirstOrDefault(i => i.Id == id);
            return get;
        }
        [HttpPost]
        public Book Create(Book book)
        {
            _book.Add(book);
            return book;
        }
        [HttpPut]
        public void Update(string id, Book bookIn)
        {
            var upd = _book.FirstOrDefault(b => b.Id == id);
            if (upd != null)
            {
                upd.BookName = bookIn.BookName;
                upd.Price = bookIn.Price;
                upd.Category = bookIn.Category;
            }
        }

        [HttpDelete]
        public void Delete(string id)
        {
            var del = _book.FirstOrDefault(x => x.Id == id);
            if (del != null)
            {
                _book.Remove(del);
            }
        }

        [HttpDelete("DeleteAll")]
        public void Delete(Book bookIn)
        {
            _book.Remove(bookIn);
        }
    }
}
