using AutoCareBackend.Repo.Model;

namespace AutoCareBackend.Service.Interfaces
{
    public interface IUserService
    {
        public Task<User> CreateUser(User user);
        public Task<User> GetUserDetail(string documentId);

    }
}
