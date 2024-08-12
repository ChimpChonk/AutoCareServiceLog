using AutoCareBackend.Repo.Data;
using AutoCareBackend.Repo.Interfaces;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private DataContext _dataContext;

        public GenericRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<T> CreateAsync(T entity, string collectionName)
        {
            await _dataContext.AddDataAsync(collectionName, entity);
            return entity;
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