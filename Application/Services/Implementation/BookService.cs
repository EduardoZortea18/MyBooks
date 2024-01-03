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

        public async Task CreateBookAsync(Book book)
        {
            await _repository.CreateAsync(book);
        }

        public async Task<List<Book>> GetBooksAsync(string id)
            => await _repository.GetAsync(id);
    }
}
