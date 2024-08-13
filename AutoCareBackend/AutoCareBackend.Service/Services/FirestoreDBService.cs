using AutoCareBackend.Service.Interfaces;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo
{
    public class FirestoreDBService : IFirestoreDBService
    {
        private readonly FirestoreDb _db;

        public FirestoreDBService()
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

        public async Task DeleteDocumentAsync(string collectionPath, string documentId)
        {
            throw new NotImplementedException();
        }

        public async Task<DocumentSnapshot> GetDocumentAsync(string collectionPath, string documentId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateDocumentAsync(string collectionPath, string documentId, object data)
        {
            throw new NotImplementedException();
        }
    }
}