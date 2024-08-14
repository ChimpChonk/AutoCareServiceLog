using AutoCareBackend.Repo.Interfaces;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo
{
    public class FirestoreDB : IFirestoreDB
    {
        private readonly FirestoreDb _db;

        public FirestoreDB()
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("./firebase/autocare-firebase.json")
            });
            _db = FirestoreDb.Create("autocare-a87a3");
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
        
        public async Task UpdateDocumentAsync(string collectionPath, string documentId, IDictionary<string, object> data)
        {
            var documentRef = _db.Collection(collectionPath).Document(documentId);
            await documentRef.UpdateAsync(data);
        }

        public async Task DeleteDocumentAsync(string collectionPath, string documentId)
        {
            var documentRef = _db.Collection(collectionPath).Document(documentId);
            await documentRef.DeleteAsync();
        }

    }
}