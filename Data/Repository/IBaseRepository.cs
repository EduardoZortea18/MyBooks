namespace Data.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAsync(string id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity, string id);
        Task DeleteAsync(string id);
        Task<List<T>> GetAllAsync();
    }
}
