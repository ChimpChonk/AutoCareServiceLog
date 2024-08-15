using AutoCareBackend.Repo.Model;

namespace AutoCareBackend.Repo.Interfaces
{
    public interface IUserRepo
    {
        public Task<User> CreateAsync(User user);
        public Task<User> GetAsync(string documentId);
        public Task<bool> UpdateAsync(string documentId, IDictionary<string, object> data);
        public Task<bool> DeleteAsync(string documentId);
    }
    
}