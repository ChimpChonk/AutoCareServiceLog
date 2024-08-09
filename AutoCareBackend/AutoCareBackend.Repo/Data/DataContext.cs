using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Data
{
    public class DataContext
    {
        public DataContext()
        {
            FirestoreDb.Create("autocare-a87a3");
        }
    }
    
}