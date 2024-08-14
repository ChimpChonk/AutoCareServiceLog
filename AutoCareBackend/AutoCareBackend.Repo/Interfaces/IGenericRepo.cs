
namespace AutoCareBackend.Repo.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        public Task<T> CreateAsync(string collectionName, T entity);
        public Task<T> GetAsync(string collectionName, string documentId);
    }
}