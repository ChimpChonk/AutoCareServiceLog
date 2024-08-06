using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Document
{
    [FirestoreData]
    public class ServiceLogDocument
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string ServiceType { get; set; }
        
        [FirestoreProperty]
        public string ServiceLocation { get; set; }

        [FirestoreProperty]
        public int Kilometers { get; set; }

        [FirestoreProperty]
        public string Description { get; set; }

        [FirestoreProperty]
        public string Cost { get; set; }

        [FirestoreProperty]
        public List<Uri> Images { get; set; }
    }
    
}