using AutoCareBackend.Repo.Interfaces;
using AutoCareBackend.Repo.Model;
using AutoCareBackend.Service.Interfaces;

namespace AutoCareBackend.Service.Services
{
    public class UserServie : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserServie(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<bool> CreateUser(User user)
        {
            // if(_userRepo.GetAsync(user.Id))
            // {

            // }
            return true;
        }

        public Task<User> GetUserDetail(string documentId)
        {
            throw new NotImplementedException();
        }
    }
}