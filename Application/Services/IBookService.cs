using Domain.Entities;

namespace Application.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync(string id);
        Task CreateBookAsync(Book book);
    }
}
