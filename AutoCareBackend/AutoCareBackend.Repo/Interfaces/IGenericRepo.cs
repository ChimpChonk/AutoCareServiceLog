
namespace AutoCareBackend.Repo.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        public Task<T> CreateAsync(T entity);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(string id);
    }
}