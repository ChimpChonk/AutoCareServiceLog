using Google.Cloud.Firestore;

namespace AutoCareBackend.Service.Interfaces
{
    public interface IFirestoreDBService
    {
        public Task<DocumentReference> CreateDocumentAsync(string collectionPath, object data);
        public Task<DocumentSnapshot> GetDocumentAsync(string collectionPath, string documentId);
        public Task UpdateDocumentAsync(string  collectionPath, string documentId, object data);
        public Task DeleteDocumentAsync(string collectionPath, string documentId);
    }
}