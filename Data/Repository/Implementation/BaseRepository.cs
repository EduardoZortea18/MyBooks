using Domain.Entities;
using Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Data.Repository.Implementation
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<T> _collectionName;

        public BaseRepository(IOptions<DatabaseSettings> dabaseSettings)
        {
            var mongoClient = new MongoClient(dabaseSettings.Value.ConnectionString);

            _database = mongoClient.GetDatabase(dabaseSettings.Value.DatabaseName);
            _collectionName = _database.GetCollection<T>(typeof(T).Name);
        }

        public async Task CreateAsync(T entity)
            => await _collectionName.InsertOneAsync(entity);

        public async Task DeleteAsync(string id)
            => await _collectionName.DeleteOneAsync(x => x.Id == id);

        public async Task<List<T>> GetAllAsync()
            => await _collectionName.FindAsync(x => x.Active).Result.ToListAsync();

        public async Task<List<T>> GetAsync(string id)
            => await _collectionName.FindAsync(x => x.Id == id).Result.ToListAsync();

        public async Task UpdateAsync(T entity, string id)
            => await _collectionName.ReplaceOneAsync(x => x.Id == id, entity);
    }
}
