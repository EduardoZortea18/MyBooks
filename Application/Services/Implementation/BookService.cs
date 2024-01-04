using Application.Dtos;
using Data.Repository;
using Domain.Entities;

namespace Application.Services.Implementation
{
    public class BookService : IBookService
    {
        private IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateBookAsync(BookRequestModel book)
        {
            var newBook = new Book
            {
                Id = book.Id,
                Active = book.Active,
                Author = book.Author,
                Price = book.Price,
                Title = book.Title,
                UpdatedAt = book.UpdatedAt,
            };

            await _repository.CreateAsync(newBook);
        }

        public async Task DeleteBookAsync(string id)
            => await _repository.DeleteAsync(id);

        public async Task<List<Book>> GetAllBooksAsync()
            => await _repository.GetAllAsync();

        public async Task<List<Book>> GetBooksAsync(string id)
            => await _repository.GetAsync(id);

        public async Task UpdateBookAsync(BookRequestModel book, string id)
        {
            var newBook = new Book
            {
                Id = book.Id,
                Active = book.Active,
                Author = book.Author,
                Price = book.Price,
                Title = book.Title,
                UpdatedAt = book.UpdatedAt,
            };
            
            await _repository.UpdateAsync(newBook, id);
        }
    }
}
