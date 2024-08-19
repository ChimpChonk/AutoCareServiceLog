using AutoCareBackend.Repo.Model;

namespace AutoCareBackend.Service.Interfaces
{
    public interface IUserService
    {
        public Task<User> AddUser(User user);
    }
}
