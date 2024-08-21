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

        public async Task<User> CreateUser(User user)
        {
            // if(user.Id == _userRepo.GetAsync(user.Id).Id)
            return await _userRepo.CreateAsync(user);
        }

        public Task<User> GetUserDetail(string documentId)
        {
            throw new NotImplementedException();
        }
    }
}