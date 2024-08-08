using AutoCareBackend.Repo.Interfaces;

namespace AutoCareBackend.Repo.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}