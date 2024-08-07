using System;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Model
{
    [FirestoreData]
    public class ServiceLog
    {
        [FirestoreProperty]
        public string Id { get; set; }

        [FirestoreProperty]
        public Vehicle Vehicle { get; set; }

        [FirestoreProperty]
        public DateTime dateTime { get; set; }

        [FirestoreProperty]
        public string ServiceType { get; set; }

        [FirestoreProperty]
        public string ServiceLocation { get; set; }

        [FirestoreProperty]
        public int Kilometers { get; set; }

        [FirestoreProperty]
        public string Description { get; set; }

        [FirestoreProperty]
        public double Cost { get; set; }   

        [FirestoreProperty]
        public List<string> Images { get; set; }

        [FirestoreProperty]
        public DateTime CreatedAt { get; set; }
    }
}