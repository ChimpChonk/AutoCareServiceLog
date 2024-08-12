
namespace AutoCareBackend.Repo.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        public Task<T> CreateAsync(T entity, string collectionName);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(string id);
    }
}