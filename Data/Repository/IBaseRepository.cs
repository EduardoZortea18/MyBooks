namespace Data.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAsync(string id);
        Task CreateAsync(T entity);
    }
}
