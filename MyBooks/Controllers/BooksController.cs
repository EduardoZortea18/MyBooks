using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetBooks([FromQuery] string id)
        {
            var result = await _service.GetBooksAsync(id);
            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookRequestModel book)
        {
            try
            {
                await _service.CreateBookAsync(book);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateBook([FromBody] BookRequestModel book, [FromQuery] string id)
        {
            try
            {
                await _service.UpdateBookAsync(book, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> UpdateBook([FromQuery] string id)
        {
            try
            {
                await _service.DeleteBookAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = await _service.GetAllBooksAsync();
            return Ok(result);
        }
    }
}
