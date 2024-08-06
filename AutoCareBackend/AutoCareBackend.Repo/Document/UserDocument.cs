using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Document
{    
    [FirestoreData]
    public class UserDocument
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Email { get; set; }

        [FirestoreProperty]
        public string UserName { get; set; }

        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public Uri ProfilePictureUrl { get; set; }

        [FirestoreProperty]
        public DateTime RegisteredDate { get; set; } = DateTime.UtcNow;
    }
}