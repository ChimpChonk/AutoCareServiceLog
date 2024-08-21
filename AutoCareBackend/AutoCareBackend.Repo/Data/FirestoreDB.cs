using AutoCareBackend.Repo.Interfaces;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo
{
    public class FirestoreDB : IFirestoreDB
    {
        private readonly FirestoreDb _db;

        public FirestoreDB(FirestoreDb db)
        {
            _db = db;
        }
        public async Task<DocumentReference> CreateDocumentAsync(string collectionPath, object data)
        {
            var collectionRef = _db.Collection(collectionPath);
            return await collectionRef.AddAsync(data);
        }

        public async Task<DocumentSnapshot> GetDocumentAsync(string collectionPath, string documentId)
        {
            var documentRef = _db.Collection(collectionPath).Document(documentId);
            return await documentRef.GetSnapshotAsync();
        }
        
        public async Task<bool> UpdateDocumentAsync(string collectionPath, string documentId, IDictionary<string, object> data)
        {
            try
            {
                var documentRef = _db.Collection(collectionPath).Document(documentId);
                await documentRef.UpdateAsync(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteDocumentAsync(string collectionPath, string documentId)
        {
            try
            {
                var documentRef = _db.Collection(collectionPath).Document(documentId);
                await documentRef.DeleteAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}