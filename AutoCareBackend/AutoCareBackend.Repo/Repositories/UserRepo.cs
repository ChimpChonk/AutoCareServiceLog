using AutoCareBackend.Repo.Interfaces;
using AutoCareBackend.Repo.Model;

namespace AutoCareBackend.Repo.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly FirestoreDB _db;
        private string collectionName = "Users";
        public UserRepo(FirestoreDB db)
        {
            _db = db;
        }
        public async Task<User> CreateAsync(User user)
        {
            await _db.CreateDocumentAsync(collectionName, user);
            return user;
        }

        public Task<bool> DeleteAsync(string documentId)
        {
            return _db.DeleteDocumentAsync(collectionName, documentId);
        }

        public async Task<User> GetAsync(string documentId)
        {
            var obj = await _db.GetDocumentAsync(collectionName, documentId);
            User data = obj.ConvertTo<User>();
            return data;
        }

        public async Task<bool> UpdateAsync(string documentId, IDictionary<string, object> data)
        {
            return await _db.UpdateDocumentAsync(collectionName, documentId,data);
        }
    }
}