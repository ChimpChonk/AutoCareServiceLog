using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Interfaces
{
    public interface IFirestoreDB
    {
        public Task<DocumentReference> CreateDocumentAsync(string collectionPath, object data);
        public Task<DocumentSnapshot> GetDocumentAsync(string collectionPath, string documentId);
        public Task<bool> UpdateDocumentAsync(string  collectionPath, string documentId, IDictionary<string, object> data);
        public Task<bool> DeleteDocumentAsync(string collectionPath, string documentId);
    }
}