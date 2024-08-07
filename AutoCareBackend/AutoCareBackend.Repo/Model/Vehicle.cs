using System;
using Google.Cloud.Firestore;

namespace AutoCareBackend.Repo.Model
{
    [FirestoreData]
    public class Vehicle
    {
        [FirestoreProperty]
        public string Id {get; set;}

        [FirestoreProperty]
        public User Owner {get; set;}

        [FirestoreProperty]
        public List<User> SharedWithUser {get; set;}

        [FirestoreProperty]
        public string Make {get; set;}

        [FirestoreProperty]
        public string Model {get; set;}

        [FirestoreProperty]
        public DateOnly Year {get; set;}

        [FirestoreProperty]
        public string RegNumber {get; set;}

        [FirestoreProperty]
        public string VehicleImage {get; set;}

        [FirestoreProperty]
        public DateTime CreatedAt {get; set;}
    }
}