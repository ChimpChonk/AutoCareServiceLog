using AutoCareBackend.Repo.Interfaces;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private FirestoreDB _db;

        public GenericRepo(FirestoreDB db)
        {
            _db = db;
        }
        public async Task<T> CreateAsync(string collectionName, T entity)
        {
            await _db.CreateDocumentAsync(collectionName, entity);
            return entity;
        }

        public async Task<T> GetAsync(string collectionName, string documentId)
        {
            var data = await _db.GetDocumentAsync(collectionName, documentId);
            T doc = data.ConvertTo<T>();
            return doc;

        }
    }
}