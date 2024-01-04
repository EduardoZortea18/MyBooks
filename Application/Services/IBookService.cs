using Application.Dtos;
using Domain.Entities;

namespace Application.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync(string id);
        Task CreateBookAsync(BookRequestModel book);
        Task UpdateBookAsync(BookRequestModel book, string id);
        Task DeleteBookAsync(string id);
        Task<List<Book>> GetAllBooksAsync();
    }
}
