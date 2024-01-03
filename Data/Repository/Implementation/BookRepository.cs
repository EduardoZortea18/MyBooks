using Domain.Entities;
using Domain.Models;
using Microsoft.Extensions.Options;

namespace Data.Repository.Implementation
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(IOptions<DatabaseSettings> settings) : base(settings)
        {
        }
    }
}
