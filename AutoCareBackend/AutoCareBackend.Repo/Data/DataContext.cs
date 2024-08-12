using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Data
{
    public class DataContext
    {
        private readonly FirestoreDb _firestoreDB;
        public DataContext()
        {
            _firestoreDB = FirestoreDb.Create("autocare-a87a3");
        }

        public async Task AddDataAsync(string collectionName, Object data)
        {
            CollectionReference collection = _firestoreDB.Collection(collectionName);
            await collection.AddAsync(data);
        }

        public async Task UpdateDataAsync(string collectionName, string data)
        {
            CollectionReference collection = _firestoreDB.Collection(collectionName);
            DocumentReference documentReference = await collection.AddAsync(data);
        }

    }
    
}