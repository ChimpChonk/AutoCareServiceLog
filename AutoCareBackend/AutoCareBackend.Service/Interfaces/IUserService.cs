using AutoCareBackend.Repo.Model;

namespace AutoCareBackend.Service.Interfaces
{
    public interface IUserService
    {
        public Task<bool> CreateUser(User user);
        public Task<User> GetUserDetail(string documentId);

    }
}
