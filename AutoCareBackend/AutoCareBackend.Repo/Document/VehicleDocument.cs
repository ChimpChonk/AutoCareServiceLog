using AutoCareBackend.Repo.Model;
using Google.Cloud.Firestore;
using Google.Cloud.Storage;

namespace AutoCareBackend.Repo.Document
{
    [FirestoreData]
    public class VehicleDocument
    {
        [FirestoreDocumentId]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Make { get; set; }

        [FirestoreProperty]
        public string Model { get; set; }

        [FirestoreProperty]
        public DateOnly Year { get; set; }

        [FirestoreProperty]
        public string RegNumber { get; set; }

        [FirestoreProperty]
        public Uri VehicleImageUrl { get; set; }

        [FirestoreProperty]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [FirestoreProperty]
        public User Owner { get; set; }

        [FirestoreProperty]
        public List<User> SharedWithUsers { get; set; }
    }
}